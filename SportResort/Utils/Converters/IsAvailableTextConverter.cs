using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace SportResort.Utils.Converters
{
    public class IsAvailableTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isAvailable = (bool)value;

            // Конвертация в текст
            string text = isAvailable ? "В наличии" : "Нет в наличии";

            // Конвертация в цвет
            Brush color = isAvailable ? Brushes.Green : Brushes.Red;

            // Возвращаем результат в зависимости от параметра
            if (parameter != null && parameter.ToString() == "Foreground")
                return color;
            else
                return text;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
