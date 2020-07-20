using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Snippets.ValueConverters
{
    public class BooleanToConverter<T> : IValueConverter
    {
        public T TrueValue { get; set; }
        public T FalseValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(bool))
                return FalseValue;

            return (bool)value ? TrueValue : FalseValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() != typeof(T))
                return false;

            return ((T)value).Equals(TrueValue);
        }
    }

}
