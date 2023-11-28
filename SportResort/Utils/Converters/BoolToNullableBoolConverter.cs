using System;
using System.Globalization;
using System.Windows.Data;

namespace SportResort.Utils.Converters
{
    public class BoolToNullableBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nullableBoolValue = value as bool?;
            return nullableBoolValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool? nullableBoolValue = value as bool?;
            return nullableBoolValue;
        }
    }
}