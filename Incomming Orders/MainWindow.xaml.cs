using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

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
            t = new DispatcherTimer();
            t.Tick += T_Tick;
            t.Interval = new TimeSpan(0, 0, 0, 1);
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("MM:dd:yy hh:mm tt");
        }

        private void img_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var host = new initial();
            host.Show();
            this.Close();
        }
    }
}
