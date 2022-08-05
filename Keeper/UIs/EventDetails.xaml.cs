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

namespace Keeper
{
    /// <summary>
    /// Interaction logic for EventDetails.xaml
    /// </summary>
    public partial class EventDetails : Window
    {
        public EventDetails(object msgs)
        {
            InitializeComponent();

            DataContext = msgs;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
