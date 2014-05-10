using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Petzold.Oscilloscope
{
    public class FormattedStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, 
                              object parameter, CultureInfo culture)
        {
            return String.Format(parameter as string, value);
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
