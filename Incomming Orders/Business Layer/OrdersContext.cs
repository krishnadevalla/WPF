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
        public static ObservableCollection<People> p = new ObservableCollection<People>();
        public static ObservableCollection<AssignGroup> ag = new ObservableCollection<AssignGroup>();
        public static int selectedIndex { get; set; }
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
                    NoOfItems = r.Next(50,200),
                    StartPlace = "DeKalb,IL",
                    AGId = "GROUP" + r.Next(0, 10),
                    DS = "ds" + r.Next(1, 5)
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
        public static void addAG()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                OrdersContext.ag.Add(new AssignGroup() {
                    InChargeId="PEOP"+r.Next(0,40),
                    GroupId="GROUP"+i
                });
            }
        }
        public static void addPeople()
        {
            string[] desig = {"Manager","Supervisor","Worker","Deputy"};
            Random r = new Random();
            for (int i = 0; i < 40; i++)
            {
                OrdersContext.p.Add(new People() {
                    Id = "PEOP" + i,
                    Desinition = desig[r.Next(0, 4)],
                    Name = "Person, with id " + "PEOP" + i,
                    Photo = r.Next(1, 6).ToString()
                });
            }
        }
    }
}
