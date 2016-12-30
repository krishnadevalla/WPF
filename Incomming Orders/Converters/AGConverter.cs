using Incomming_Orders.Business_Layer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Incomming_Orders.Converters
{
    class AGConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string st = value.ToString();
            string s = OrdersContext.ag.Where(e => e.GroupId == st).ToList<AssignGroup>().First<AssignGroup>().InChargeId;
            return "Resource/People/" + OrdersContext.p.Where(e => e.Id == s).ToList<People>().First<People>().Photo + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
