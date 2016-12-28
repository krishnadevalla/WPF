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
using Incomming_Orders.Business_Layer.AppData;
using System.Security.Cryptography;

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
                AppData.initialToMainWindowsSecret = Encoding.UTF8.GetString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes("AL10$TLPWIOJMNI59%3#9)!^LOENDGG$$&WE~!")));
                var host = new MainWindow() {Tag="hello" };
                host.Show();
                this.Close();
            }
        }
    }
}
