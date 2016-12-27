using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incomming_Orders.Business_Layer
{
    public class Order
    {
        public string OrderId { set; get; }
        public string AGId { set; get; }
        public int Priority { set; get; } 
        public DateTime OrderDate { set; get; }
        public DateTime ScheduledDate { set; get; }
        public int DelayedDays { set; get; }
        public int NoOfItems { set; get; }
        public string DS { set; get; }
        public string StartPlace { set; get; } 
    }
    public class DeliveryService
    {
        public string DSId { get; set; }
        public string DSName { set; get; }
    }
    public class AssignGroup
    {
        public string InChargeId { set; get; }
        public string GroupId { set; get; }
    }
    class People
    {
        string Id { get; set; }
        string Name { get; set; }
        string Photo { set; get; }
        string Desinition { set; get; }
    }
}
