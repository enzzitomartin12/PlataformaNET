﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubmitApplicationTest.cs" company="Microsoft">
//   Copyright (c) Microsoft Corporation. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace HRServices.Tests
{
    using System;
    using System.Activities;
    using System.Activities.Statements;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    using HRApplicationServices.Activities;
    using HRApplicationServices.Application;
    using HRApplicationServices.Contracts;

    using HRServices.Tests.Activities;

    using Microsoft.Activities.Extensions.Tracking;
    using Microsoft.Activities.UnitTesting;
    using Microsoft.Activities.UnitTesting.Stubs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using SubmitJobApplicationRequest = HRApplicationServices.Contracts.SubmitJobApplicationRequest;

    /// <summary>
    /// Tests the SubmitApplication Workflow
    /// </summary>
    [TestClass]
    public class SubmitApplicationTest
    {
        #region Constants and Fields

        /// <summary>
        ///   The applicantid arg name.
        /// </summary>
        private const string ApplicantidArgName = "ApplicantID";

        /// <summary>
        ///   The applicationid arg name.
        /// </summary>
        private const string ApplicationidArgName = "ApplicationID";

        /// <summary>
        ///   The educationpassed arg name.
        /// </summary>
        private const string EducationpassedArgName = "EducationPassed";

        /// <summary>
        ///   The hire approved arg name.
        /// </summary>
        private const string HireApprovedArgName = "HireApproved";

        /// <summary>
        ///   The request human screening display name.
        /// </summary>
        private const string RequestHumanScreeningDisplayName = "Request Human Screening";

        /// <summary>
        ///   The retrycount arg name.
        /// </summary>
        private const string RetrycountArgName = "RetryCount";

        /// <summary>
        ///   The update hire approved display name.
        /// </summary>
        private const string UpdateHireApprovedDisplayName = "Update Hire Approved";

        /// <summary>
        ///   The binding to use when testing
        /// </summary>
        private readonly Binding binding = new NetNamedPipeBinding();

        /// <summary>
        ///   The endpoint address to be used by the test host
        /// </summary>
        private readonly EndpointAddress serviceAddress = new EndpointAddress("net.pipe://localhost/SubmitApplication");

        #endregion

        #region Public Properties

        /// <summary>
        ///  Gets or sets the test context which provides
        ///  information about and functionality for the current test run.
        /// </summary>
        public TestContext TestContext { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Verifies that an applicant with the education level of Masters should be hired when the human screening approves
        /// </summary>
        /// <remarks>
        /// Given
        ///   * A job application request with an education level of Masters
        ///   When
        ///   * The the application is submitted to the service
        ///   Then
        ///   * The AutoScreen education activity will indicate the application passed education screening
        ///   * Human screening will be requested
        ///   When
        ///   * The Human approves the application
        ///   Then
        ///   * The UpdateHireActivity will be invoked with HireApproved = true to update the database
        ///   * The NotifyApplicantActivity will be invoked with Hire = true to notify the applicant
        /// </remarks>
        [TestMethod]
        [DeploymentItem(@"HRApplicationServices\SubmitApplication.xamlx")]
        public void EducationLevelMastersWhenSentShouldHireWhenHumanApproves()
        {
            const string ExpectedName = "test";
            const int ExpectedId = 123;
            var expectedResponse = string.Format(ServiceResources.JobApplicationProcessing, ExpectedName, ExpectedId);

            // XamlInjector will replace activities with Mocks suitable for testing
            var xamlInjector = new XamlInjector("SubmitApplication.xamlx");

            // The first phase builds a set of replacement rules
            xamlInjector.ReplaceAll(typeof(NotifyApplicant), typeof(MockNotifyApplicant));
            xamlInjector.ReplaceAll(typeof(RequestHumanScreening), typeof(MockRequestHumanScreening));
            xamlInjector.ReplaceAll(typeof(SaveJobApplication), typeof(MockSaveJobApplication));
            xamlInjector.ReplaceAll(typeof(UpdateHireApproved), typeof(MockUpdateHireApproved));
            xamlInjector.ReplaceAll(typeof(Delay), typeof(DelayStub));

            // Then we load the service and replace the activities with mocks
            var mockedService = xamlInjector.GetWorkflowService();

            // Setup the DelayStub timeout
            // Keep it short but long enough to receive the second message
            DelayStub.StubDuration = TimeSpan.FromSeconds(1);

            // Host the service
            using (var host = WorkflowServiceTestHost.Open(mockedService, this.serviceAddress))
            {
                // Arrange
                // Setup a proxy to use named pipes
                // Using the proxy generated by a service reference
                var proxy = new ApplicationServiceClient(this.binding, this.serviceAddress);

                try
                {
                    // Act
                    // When the the application is submitted to the service
                    var response = proxy.SubmitJobApplication(CreateApplicationRequest());

                    // Check that we got a response message
                    Assert.AreEqual(expectedResponse, response.ResponseText);

                    // When the Human approves the application
                    var result =
                        proxy.HumanScreeningCompleted(
                            new HumanScreeningResult { AppID = ExpectedId, HiringApproved = true });

                    // Check that the response was accepted
                    Assert.IsTrue(result.HasValue && result.Value);

                    proxy.Close();

                    // Close the host
                    host.Close();
                    Assert.IsTrue(host.WaitForHostClosed());

                    // Assert
                    // Assert that the Auto Screen Education activity returned EducationPassed = true
                    // 55: Activity [67] "Auto Screen Education" is Closed
                    // {
                    // Arguments
                    // EducationPassed: True
                    // Education: Masters
                    // }
                    host.Tracking.Assert.ExistsArgValue(
                        "Auto Screen Education", ActivityInstanceState.Closed, EducationpassedArgName, true);

                    // Assert that the Request Human Screening activity was invoked
                    // 69: Activity [60] "Request Human Screening" is Closed
                    // {
                    // Arguments
                    // ApplicationRequest: HRApplicationServices.Contracts.SubmitJobApplicationRequest
                    // RetryCount: 0
                    // ApplicationID: 123
                    // }
                    var requestHumanScreening = host.Tracking.Records.Find(
                        RequestHumanScreeningDisplayName, ActivityInstanceState.Closed);

                    Assert.IsNotNull(requestHumanScreening, "Could not find Request Human Screening");
                    Assert.AreEqual(
                        ExpectedId, 
                        requestHumanScreening.GetArgument<int>(ApplicationidArgName), 
                        "On first Human Screening Request Applicant ID does not match request");
                    Assert.AreEqual(
                        0, 
                        requestHumanScreening.GetArgument<int>(RetrycountArgName), 
                        "On first Human Screening Request RetryCount is not zero");

                    // Assert that the Update Hire activity was invoked
                    // 109: Activity [45] "Update Hire Approved" is Closed
                    // {
                    // Arguments
                    // ApplicantID: 123
                    // HireApproved: True
                    // }
                    host.Tracking.Assert.ExistsArgValue(
                        UpdateHireApprovedDisplayName, ActivityInstanceState.Closed, HireApprovedArgName, true);
                    host.Tracking.Assert.ExistsArgValue(
                        UpdateHireApprovedDisplayName, ActivityInstanceState.Closed, ApplicantidArgName, ExpectedId);

                    // Assert that the hire email notification was sent
                    // 140: Activity [4] "MockNotifyApplicant" is Closed
                    // {
                    // Arguments
                    // Cancel: False
                    // Hire: True
                    // Resume: HRApplicationServices.Contracts.ApplicantResume
                    // }
                    var notifyApplicant = host.Tracking.Records.Find(
                        "MockNotifyApplicant", ActivityInstanceState.Closed);
                    Assert.IsNotNull(notifyApplicant, "Could not find the MockNotifyApplication activity");
                    Assert.IsTrue(
                        notifyApplicant.GetArgument<bool>("Hire"), 
                        "The applicant notify activity did not have argument Hire=true");
                    Assert.AreEqual(
                        "test", 
                        notifyApplicant.GetArgument<ApplicantResume>("Resume").Name, 
                        "The NotifyApplication activity did not have the correct applicant name");
                }
                finally
                {
                    host.Tracking.Trace();
                }
            }
        }

        /// <summary>
        /// Verifies that an application cancels after two nag emails are sent
        /// </summary>
        /// <remarks>
        /// Given
        ///   * a Job application sent to the WorkflowService
        ///   * with an education level that will pass screening
        ///   When
        ///   * The human is unresponsive
        ///   Then
        ///   * Two emails will be sent to the HR administrator
        ///   * The applicant will be notified that the application was canceled
        /// </remarks>
        [TestMethod]
        [DeploymentItem(@"HRApplicationServices\SubmitApplication.xamlx")]
        public void ServiceShouldCancelAfter2Nags()
        {
            const string ExpectedName = "test";
            const int ExpectedId = 123;
            var expectedResponse = string.Format(ServiceResources.JobApplicationProcessing, ExpectedName, ExpectedId);

            var xamlInjector = new XamlInjector("SubmitApplication.xamlx");
            xamlInjector.ReplaceAll(typeof(NotifyApplicant), typeof(MockNotifyApplicant));
            xamlInjector.ReplaceAll(typeof(RequestHumanScreening), typeof(MockRequestHumanScreening));
            xamlInjector.ReplaceAll(typeof(SaveJobApplication), typeof(MockSaveJobApplication));
            xamlInjector.ReplaceAll(typeof(Delay), typeof(DelayStub));
            xamlInjector.ReplaceAll(typeof(UpdateHireApproved), typeof(MockUpdateHireApproved));

            // Setup the DelayStub with a very short delay - we want it to cancel quickly
            DelayStub.StubDuration = TimeSpan.FromMilliseconds(1);

            // Host the service);
            using (var host = WorkflowServiceTestHost.Open(xamlInjector.GetWorkflowService(), this.serviceAddress))
            {
                // Setup a proxy to use named pipes
                var proxy = new ApplicationServiceClient(this.binding, this.serviceAddress);

                try
                {
                    var applicationRequest = CreateApplicationRequest();

                    // Submit an application
                    var response = proxy.SubmitJobApplication(applicationRequest);

                    // Check that we got a response message
                    Assert.AreEqual(expectedResponse, response.ResponseText);

                    // Take no further action - application should cancel
                    proxy.Close();

                    // The last thing to happen is for the Workflow Instance to be deleted from
                    // the persistence store.
                    // Wait for this before asserting tracking records
                    Assert.IsTrue(host.WaitForInstanceDeleted());

                    // Close the host
                    host.Close();
                    Assert.IsTrue(host.WaitForHostClosed());

                    // Assert

                    // Find the first notification to the HR Administrator
                    // 69: Activity [60] "Request Human Screening" is Closed at 07:03:54.4424
                    // {
                    // Arguments
                    // ApplicationRequest: HRApplicationServices.Contracts.SubmitJobApplicationRequest
                    // RetryCount: 0
                    // ApplicationID: 123
                    // }
                    var request1 = host.Tracking.Records.Find(
                        RequestHumanScreeningDisplayName, ActivityInstanceState.Closed);
                    Assert.IsNotNull(request1, "Could not find first request notification");
                    Assert.AreEqual(
                        0, request1.GetArgument<int>(RetrycountArgName), "Retry count was not zero on first request");

                    // Find the second notification to the HR Administrator
                    // 115: Activity [60] "Request Human Screening" is Executing at 07:03:54.4454
                    // {
                    // Arguments
                    // ApplicationRequest: HRApplicationServices.Contracts.SubmitJobApplicationRequest
                    // RetryCount: 1
                    // ApplicationID: 123
                    // }                    
                    var request2 = host.Tracking.Records.Find(
                        RequestHumanScreeningDisplayName, ActivityInstanceState.Closed, request1.RecordNumber + 1);
                    Assert.IsNotNull(request2, "Could not find second request notification");
                    Assert.AreEqual(
                        1, request2.GetArgument<int>(RetrycountArgName), "Retry count was not one on second request");

                    // Find the cancel notification
                    // 167: Activity [4] "MockNotifyApplicant" is Closed at 07:03:54.4474
                    // {
                    // Arguments
                    // Cancel: True
                    // Hire: False
                    // Resume: HRApplicationServices.Contracts.ApplicantResume
                    // }
                    var notifyApplicant = host.Tracking.Records.Find(
                        "MockNotifyApplicant", ActivityInstanceState.Closed);
                    Assert.IsNotNull(notifyApplicant, "Could not find Cancel notification");
                    Assert.IsFalse(
                        notifyApplicant.GetArgument<bool>("Hire"), 
                        "Hire argument was not false when the application was canceled");
                    Assert.IsTrue(notifyApplicant.GetArgument<bool>("Cancel"), "Cancel argument was not true");
                }
                finally
                {
                    host.Tracking.Trace();
                }
            }
        }

        /// <summary>
        /// The should not hire eduction level none.
        /// </summary>
        [TestMethod]
        [DeploymentItem(@"HRApplicationServices\SubmitApplication.xamlx")]
        public void ShouldNotHireEductionLevelNone()
        {
            const string ExpectedName = "test";
            const int ExpectedId = 123;
            var expectedResponse = string.Format(ServiceResources.JobApplicationProcessing, ExpectedName, ExpectedId);

            var xamlInjector = new XamlInjector("SubmitApplication.xamlx");
            xamlInjector.ReplaceAll(typeof(NotifyApplicant), typeof(MockNotifyApplicant));
            xamlInjector.ReplaceAll(typeof(RequestHumanScreening), typeof(MockRequestHumanScreening));
            xamlInjector.ReplaceAll(typeof(SaveJobApplication), typeof(MockSaveJobApplication));
            xamlInjector.ReplaceAll(typeof(UpdateHireApproved), typeof(MockUpdateHireApproved));

            // Host the service);
            using (var host = WorkflowServiceTestHost.Open(xamlInjector.GetWorkflowService(), this.serviceAddress))
            {
                // Setup a proxy to use named pipes
                var proxy = new ApplicationServiceClient(this.binding, this.serviceAddress);

                try
                {
                    // Submit an application
                    var response = proxy.SubmitJobApplication(CreateApplicationRequest("none"));

                    proxy.Close();

                    // The last thing to happen is for the Workflow Instance to be deleted from
                    // the persistence store.
                    // Wait for this before asserting tracking records
                    Assert.IsTrue(host.WaitForInstanceDeleted());

                    // Close the host
                    host.Close();

                    // Assert

                    // Check that we got a response message
                    Assert.AreEqual(expectedResponse, response.ResponseText);

                    host.Tracking.Trace();

                    // Assert that the Auto Screen Education activity returned EducationPassed = false

                    // Find this tracking record and assert the arguments
                    // Activity <Auto Screen Education> state is Closed
                    // {
                    // Arguments
                    // EducationPassed: False
                    // Education: None
                    // }

                    // After the autoscreen the EducationPassed argument should be false
                    var autoScreenEducation = host.Tracking.Records.Find(
                        "Auto Screen Education", ActivityInstanceState.Closed);

                    Assert.IsFalse(autoScreenEducation.GetArgument<bool>(EducationpassedArgName));

                    // Assert that the Update No Hire activity was invoked

                    // Find this activity state record
                    // Activity <Update No Hire> state is Closed
                    // {
                    // Arguments
                    // ApplicantID: 123
                    // HireApproved: False
                    // }
                    var updateNoHire = host.Tracking.Records.Find("Update No Hire", ActivityInstanceState.Closed);
                    Assert.IsFalse(updateNoHire.GetArgument<bool>(HireApprovedArgName));

                    // Assert that the no-hire email notification was sent

                    // Find this activity state record
                    // Activity <MockNotifyApplicant> state is Closed
                    // {
                    // Arguments
                    // Hire: False
                    // Resume: HRApplicationServices.Contracts.ApplicantResume
                    // }
                    var notifyApplicant = host.Tracking.Records.Find(
                        "MockNotifyApplicant", ActivityInstanceState.Closed);
                    Assert.IsFalse(notifyApplicant.GetArgument<bool>("Hire"));
                }
                catch (Exception)
                {
                    proxy.Abort();
                    throw;
                }
                finally
                {
                    host.Tracking.Trace();
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The create application request.
        /// </summary>
        /// <param name="education">
        /// The education.
        /// </param>
        /// <returns>
        /// A job application request
        /// </returns>
        private static SubmitJobApplicationRequest CreateApplicationRequest(string education = "Masters")
        {
            return new SubmitJobApplicationRequest
                {
                    RequestID = Guid.NewGuid(), 
                    Resume =
                        new ApplicantResume
                            {
                               Education = education, Email = "test@test.org", Name = "test", NumReferences = 0 
                            }
                };
        }

        #endregion
    }
}