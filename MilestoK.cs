using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ConvertValue
{
    internal class MilestoK : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val;
            double d;
            if (double.TryParse((string)value, out val))
            /*double d = double.Parse((string)value);*/
            {
                d = val;
                d *= 1.6934;
                return d.ToString("f2");
            }
            else
            {
                return value;
            }
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
