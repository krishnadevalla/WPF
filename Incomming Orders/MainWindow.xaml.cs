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
using System.Windows.Media;
using Incomming_Orders.Business_Layer.AppData;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;
using System.IO;

namespace Incomming_Orders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer t;
        Brush bgc = null;
        public MainWindow()
        {
            InitializeComponent();
            if (Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes("AL10$TLPWIOJMNI59%3#9)!^LOENDGG$$&WE~!")))== AppData.initialToMainWindowsSecret)
            {
                OrdersContext.addOrders();
                OrdersContext.addPeople();
                OrdersContext.addAG();
                OrdersContext.addDS();
                OrdersContext.sortOrder();
                serializeCollection(); // Writing collection to file and clearing collection and reassigning
                listorders.DataContext= OrdersContext.Orders;
                listorders.SelectedIndex = 0;
                t = new DispatcherTimer();
                t.Tick += T_Tick;
                t.Interval = new TimeSpan(0, 0, 0, 1);
                t.Start();
            }
            else
            {
                initial n = new initial();
                n.Show();
                this.Close();
            }
        }

        private void serializeCollection()
        {
            File.WriteAllText("Orders.json",JsonConvert.SerializeObject(OrdersContext.Orders));
            OrdersContext.Orders.Clear();
            OrdersContext.Orders= JsonConvert.DeserializeObject<ObservableCollection<Order>>(File.ReadAllText("Orders.json"));
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
        private void Border_MouseEnter(object sender, MouseEventArgs e)
        {
            bgc = (sender as Border).Background;
            (sender as Border).Background = Brushes.Yellow;
        }

        private void Border_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as Border).Background = bgc;
        }
        private void listorders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedOrder.DataContext = listorders.SelectedItem;

        }

        private void deliveredOrdersCheck_Checked(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            for (int i = 30; i < 40; i++)
            {
                OrdersContext.Orders.Add(new Order()
                {
                    OrderId = "ORD0" + i,
                    Priority = r.Next(0, 4),
                    OrderDate = DateTime.Parse("12/20/2016 10:30:20 AM"),
                    ScheduledDate = DateTime.Parse("12/23/2016 12:12 PM").AddDays(r.Next(-3, 3)),
                    DelayedDays = 0,
                    NoOfItems = 120,
                    StartPlace = "DeKalb,IL",
                    AGId = "G" + r.Next(0, 10),
                    DS = "ds" + r.Next(1, 4)
                });
            }
            OrdersContext.sortOrder();
            listorders.DataContext = OrdersContext.Orders;
        }

        private void deliveredOrdersCheck_Unchecked(object sender, RoutedEventArgs e)
        {
            foreach (var item in OrdersContext.Orders.ToList())
            {
                if (item.ScheduledDate.Date < DateTime.Now.Date)
                    OrdersContext.Orders.Remove(item);
            }
        }
    }
}
