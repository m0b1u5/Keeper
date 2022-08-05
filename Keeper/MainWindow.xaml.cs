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

namespace Keeper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //startup frame with a new page

      /*  public void initialpage()
        {
            var newpath = new navpaths();

            newpath.navpath = "/Pages/Dashboard.xaml";

            

            

            navFrame.Navigate(newpath.navpath);
        }

        private class navpaths
        {
            public string navpath { get; set; }
        }*/



        //Data used to initialize the database

            IEnumerable<Event> evente = new List<Event>
        {
            new Event{ Title ="Extravaganza", StartDate ="08/08/2022",  Description="Music Extravaganza to Showcase our Local artists", Price=500 },
            new Event{ Title ="Music Concert", StartDate ="08/15/2022", Description="Music concert inviting various international artists and local stars ", Price=500 }

        };



        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = sidebar.SelectedItem as NavButton;
            navFrame.Navigate(selected.Navlink);

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }

        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.Close();
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;


        }
    }
}
