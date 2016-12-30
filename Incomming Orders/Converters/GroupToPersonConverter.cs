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
    class GroupToPersonConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = value.ToString();
            if (parameter.ToString()=="name")
            {
                string ss = OrdersContext.ag.Where(e => e.GroupId == s).ToList<AssignGroup>().First<AssignGroup>().InChargeId.ToString();
                return OrdersContext.p.Where(e => e.Id == ss).ToList<People>().First<People>().Name;
            }    
            else
            {
                string ss = OrdersContext.ag.Where(e => e.GroupId == s).ToList<AssignGroup>().First<AssignGroup>().InChargeId.ToString();
                return OrdersContext.p.Where(e => e.Id == ss).ToList<People>().First<People>().Id;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
