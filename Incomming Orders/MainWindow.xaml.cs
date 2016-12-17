using Incomming_Orders.Business_Layer;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Threading;
using System.Globalization;
using System.Collections.ObjectModel;
using System.Linq;

namespace Incomming_Orders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t;
        public MainWindow()
        {
            InitializeComponent();
            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                OrdersContext.Orders.Add(new Order()
                {
                    OrderId = "ord"+i,
                    Priority = r.Next(0,4),
                    OrderDate = DateTime.Parse("12/12/2016 10:30:20 AM"),
                    ScheduledDate = DateTime.Parse("12/16/2016 12:12 PM").AddDays(r.Next(0, 10)),
                    DelayedDays = 0,
                    NoOfItems = 120,
                    StartPlace = "DeKalb,IL",
                    AGId = "G"+r.Next(0,10),
                    DS = "D101"
                });
            }
            OrdersContext.Orders = new ObservableCollection<Order>(OrdersContext.Orders.OrderBy(i=>i.ScheduledDate));
            listorders.DataContext = OrdersContext.Orders;
            t = new DispatcherTimer();
            t.Tick += T_Tick;
            t.Interval = new TimeSpan(0, 0, 0, 1);
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("MM:dd:yy hh:mm tt");
        }

        private void Img_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var host = new initial();
            host.Show();
            this.Close();
        }
    }
}
