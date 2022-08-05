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

namespace Keeper.Pages
{
    /// <summary>
    /// Interaction logic for Members.xaml
    /// </summary>
    public partial class Members : Page
    {
        

        public Members()
        {
            InitializeComponent();



            var kp = new KeepersDb();

            var mquery = from member in kp.people
                         select member;

            var allpeople = mquery.ToList();

            



            var mymember = new[]
            {
                new {   Name = "Jenner jenw", 
                        Age = "24", 
                        Gender = "male", 
                        Phone = "01234567894", 
                        Email = "jennejne@mailers.com", 
                        Status = "member", 
                        Minister = "1", 
                        Address = "22 Donning",
                        City = "Nairobi"},

                 new {   Name = "Jon batiste",
                        Age = "29",
                        Gender = "male",
                        Phone = "01237897894",
                        Email = "jonbatiste@mailers.com",
                        Status = "member",
                        Minister = "1",
                        Address = "2 Jersey",
                        City = "Nairobi"},

                  new {   Name = "John Opiyo",
                        Age = "44",
                        Gender = "male",
                        Phone = "0126512894",
                        Email = "jopiyo@mailers.com",
                        Status = "member",
                        Minister = "1",
                        Address = "Straw Ben",
                        City = "Nairobi"},

                   new {   Name = "Jane Kui",
                        Age = "34",
                        Gender = "Female",
                        Phone = "012345621487",
                        Email = "jkui@mailers.com",
                        Status = "member",
                        Minister = "1",
                        Address = "22 Donning",
                        City = "Nairobi"},



            };

            MemberGrid.ItemsSource = allpeople;
            //MemberGrid.ItemsSource = mymember;
        }



             






          

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                var row = e.Source as DataGridRow;

                memberdata Memberdata = new memberdata(row.Item);
                //Memberdata.Owner = MainWindow;
                Memberdata.Show();
            }




        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var adder = new addmember();
            adder.Show();

        }
    }
}
