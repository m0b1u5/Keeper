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
    /// Interaction logic for memberdata.xaml
    /// </summary>
    public partial class memberdata : Window
    {
        public memberdata(object profile)
        {
            InitializeComponent();

            DataContext = profile;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }
    }
}
