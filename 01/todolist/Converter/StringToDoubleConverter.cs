﻿using System;
using System.Globalization;
using Avalonia.Data.Converters;

namespace todolist.Converters
{
    public class StringToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return doubleValue.ToString(culture);
            }
            return "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue && double.TryParse(stringValue, NumberStyles.Any, culture, out double result))
            {
                return result;
            }
            return 0.0;
        }
    }
}