using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace MVVM_Tutorial_Practice.ViewModel.Converters
{
    public class RainingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isRaining = (bool)value;

            if (isRaining)
                return "Currently raining!";

            return "Currently not raining!";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string IsRaining = (string)value;
            if (IsRaining == "Currently raining!")
                return true;
            return false;
        }
    }
}
