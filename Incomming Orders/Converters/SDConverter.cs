using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Incomming_Orders.Converters
{
    public class SDConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime v = DateTime.Parse(value.ToString().Substring(0, 8));
            if (DateTime.Now.Date == v)
                return "Today";
            else if (DateTime.Now.AddDays(1).ToString().Substring(0, 8) == v.ToString().Substring(0, 8))
                return "Tomorrow";
            else if (DateTime.Now.AddDays(2).ToString().Substring(0, 8) == v.ToString().Substring(0, 8))
                return "Day after Tomorrow";
            else if (DateTime.Now.Date > v)
                return "Delivered";
            return DateTime.Parse(value.ToString()).ToString("MMMM dd, yyyy") ;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
