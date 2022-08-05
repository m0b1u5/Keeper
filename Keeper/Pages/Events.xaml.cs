using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Events.xaml
    /// </summary>
    public partial class Events : Page
    {
        public string DescCustodian = " Primary duties: A custodian works in the church and its related buildings, cleaning and repairing the rooms and items in them. They dust, mop, vacuum, clean restrooms in the church rooms and the sanctuary or the surrounding landscape. They may also work in the schools and other administrative buildings associated with the Catholic Church. Custodians may also  perform maintenance on furniture or damage that may occur through the use of these buildings. They may record their various activities to monitor what may need to be replaced or have a specialist come in";

        public Events()
        {
            InitializeComponent();
        }




        IEnumerable<Event> evente = new List<Event>
        {
            new Event{ Title ="Extravaganza", StartDate ="08/08/2022", Description="Music Extravaganza to Showcase our Local artists", Price=500, Address="Donning Street"},
            new Event{ Title ="Music Concert", StartDate ="08/15/2022", Description="Music concert inviting various international artists and local stars ", Price=500, Address="Donning Street" } };

        IEnumerable<Job> jobs = new List<Job>
        {
            new Job{ Title = "Custodian", Description= " Primary duties: A custodian works in the church and its related buildings", Salary = 30000  }
        };




        private void pops_Click(object sender, RoutedEventArgs e)
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<KeepersDb>());

            //var db = new KeptDb();

            var deb = new KeepersDb();

            foreach (var job in jobs)
            {
                deb.jobs.Add(job);
                deb.SaveChanges();

                MessageBox.Show("Query Successful");
            }





      //      foreach (var ev in evente)
      //      {
      //          db.events.Add(ev);
      //      }
      //      MessageBox.Show("Events Added");
      //      db.SaveChanges();

      //      MessageBox.Show("database Saved");








        }
    }
}
