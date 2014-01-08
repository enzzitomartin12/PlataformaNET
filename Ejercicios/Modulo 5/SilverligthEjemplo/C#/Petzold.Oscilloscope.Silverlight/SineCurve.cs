using System;
using System.Windows;

namespace Petzold.Oscilloscope
{
    public class SineCurve : FrameworkElement, IProvideAxisValue
    {
        double phaseAngle = 0;
        DateTime lastDateTime = DateTime.Now;

        // Frequency in cycles per second
        public static readonly DependencyProperty FrequencyProperty =
            DependencyProperty.Register("Frequency",
                typeof(double),
                typeof(SineCurve),
                new PropertyMetadata(1.0));

        public static readonly DependencyProperty AmplitudeProperty =
            DependencyProperty.Register("Amplitude",
                typeof(double),
                typeof(SineCurve),
                new PropertyMetadata(1.0));

        public double Frequency
        {
            set { SetValue(FrequencyProperty, value); }
            get { return (double)GetValue(FrequencyProperty); }
        }

        public double Amplitude
        {
            set { SetValue(AmplitudeProperty, value); }
            get { return (double)GetValue(AmplitudeProperty); }
        }

        public double GetAxisValue(DateTime dateTime)
        {
            phaseAngle += 2 * Math.PI * this.Frequency * 
                    (dateTime - lastDateTime).TotalSeconds;
            phaseAngle %= 2 * Math.PI;
            lastDateTime = dateTime;

            return this.Amplitude * Math.Sin(phaseAngle);
        }
    }
}
