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
        public static void addOrders()
        {
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                OrdersContext.Orders.Add(new Order()
                {
                    OrderId = "ORD0" + i,
                    Priority = r.Next(0, 4),
                    OrderDate = DateTime.Now.AddDays(-8),
                    ScheduledDate = DateTime.Now.AddDays(r.Next(0, 10)),
                    DelayedDays = 0,
                    NoOfItems = 120,
                    StartPlace = "DeKalb,IL",
                    AGId = "G" + r.Next(0, 10),
                    DS = "ds" + r.Next(1, 4)
                });
            }
        }
        public static void addDS()
        {
            OrdersContext.ds.Add(new DeliveryService() { DSId = "ds1", DSName = "USPS" });
            OrdersContext.ds.Add(new DeliveryService() { DSId = "ds2", DSName = "UPS" });
            OrdersContext.ds.Add(new DeliveryService() { DSId = "ds3", DSName = "FEDEX" });
            OrdersContext.ds.Add(new DeliveryService() { DSId = "ds4", DSName = "DHL" });
        }
        public static void sortOrder()
        {
            OrdersContext.Orders = new ObservableCollection<Order>(OrdersContext.Orders.OrderBy(i => i.ScheduledDate));
        }

    }
}
