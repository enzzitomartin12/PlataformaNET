using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Activities;

namespace UnitTestForWFProgram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var output = WorkflowInvoker.Invoke(new WorkflowForTest());
            Assert.AreEqual("Test Message", output["OutMessage"]);
        }
    }
}
