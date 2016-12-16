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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Incomming_Orders
{
    /// <summary>
    /// Interaction logic for initial.xaml
    /// </summary>
    public partial class initial : Window
    {
        public initial()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (userid.Text.Equals("hello") && pass.Password.Equals("hello"))
            {
                
                var host = new MainWindow();
                host.Show();
                this.Close();
            }
        }
    }
}
