using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LissajousCurves.Phone
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs args)
        {
            AppSettings appSettings = (Application.Current as App).AppSettings;

            appSettings.XAmplitude = xAmplitude.Value;
            appSettings.XFrequency = xFrequency.Value;
            appSettings.YAmplitude = yAmplitude.Value;
            appSettings.YFrequency = yFrequency.Value;
            appSettings.Brightness = brightness.Value;
            appSettings.Persistence = persistence.Value;

            base.OnNavigatedFrom(args);
        }

        protected override void OnNavigatedTo(NavigationEventArgs args)
        {
            AppSettings appSettings = (Application.Current as App).AppSettings;

            xAmplitude.Value = appSettings.XAmplitude;
            xFrequency.Value = appSettings.XFrequency;
            yAmplitude.Value = appSettings.YAmplitude;
            yFrequency.Value = appSettings.YFrequency;
            brightness.Value = appSettings.Brightness;
            persistence.Value = appSettings.Persistence;

            base.OnNavigatedTo(args);
        }
    }
}