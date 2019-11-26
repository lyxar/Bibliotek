using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Bibliotek.Converters
{
    public class BorrowedDateToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int borrowedDays = (DateTime.Today - (DateTime)value).Days;
            if (borrowedDays > 10)
            {
                return "Red";
            }
            if (borrowedDays > 5)
            {
                return "Orange";
            }
            return "Green";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
