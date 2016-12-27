using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incomming_Orders.Business_Layer
{
    public static class OrdersContext
    {
        public static ObservableCollection<Order> Orders=new ObservableCollection<Order>();
        public static ObservableCollection<DeliveryService> ds = new ObservableCollection<DeliveryService>();

    }
}
