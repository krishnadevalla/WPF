using Incomming_Orders.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Incomming_Orders
{
    /// <summary>
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Window
    {
        public EditPage()
        {
            InitializeComponent();
            this.DataContext = OrdersContext.Orders[OrdersContext.selectedIndex];
            assign.DataContext = OrdersContext.ag ;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OrdersContext.Orders.RemoveAt(OrdersContext.selectedIndex);
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OrdersContext.Orders[OrdersContext.selectedIndex] = OrdersContext.Orders[OrdersContext.selectedIndex - 1];
            this.Close();
        }
    }
}
