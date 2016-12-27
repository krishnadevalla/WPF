using Incomming_Orders.Business_Layer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml.Linq;

namespace Incomming_Orders.Converters
{
    class DSConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string s = value.ToString();
            return "Resource/logos/"+OrdersContext.ds.Where(e => e.DSId == s).ToList<DeliveryService>().First<DeliveryService>().DSName+".png";
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
