using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Bibliotek.Converters
{
    public class BorrowedDateToColor : IValueConverter
    {
        //Converter used to change the color of a specifik item depending on the amount of time a book is borrowed
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Compares the time of the borrowed book with the current time and gets the day difference.
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
            return value;
        }
    }
}
