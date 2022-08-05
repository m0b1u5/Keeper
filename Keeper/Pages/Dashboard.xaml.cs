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
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Page
    {
        
       

        

        public Dashboard()
        {
            InitializeComponent();

           


            //Starting connection to the database

            var db = new KeepersDb();

            //get a data set of messages from the database
            var query = from msg in db.messangers
                        orderby msg.id descending
                        select msg;

            //get only 10 messages from the messages table, arranged in descending order, showing the 10 latest messages
            var msgs = query.Take(10).ToList();

            //get a tally of new members, the are assigned to a certain minister
           


            //Get a data set of Events from the events table, arranged in descending order to show the latest 10 events
            var revent = from rcnt in db.eventcals
                         orderby rcnt.Id descending
                         select rcnt;

            //select 10 events from the result above
            var recentevent = revent.Take(10).ToList();

            //Get a dataset of all members
            var membership = from memb in db.people
                             select memb;

            //populate the new members number
            var newmembers = from neww in membership
                             where neww.Status == "Visitor"
                             select neww;
            newmemberstext.Text = newmembers.Count().ToString();


            //Get a count of how many members there are in the database
            memberstext.Text = membership.ToList().Count().ToString();

           //Get all donations information from the database into donationinfo variable
            var donationinfo = from don in db.donations
                               select don;

            //query donationinfo for totals

            var donationtotal = donationinfo.Sum(donationinfo => donationinfo.Amount);

            donationstext.Text = donationtotal.ToString();

            try
            {
                //donation stats, donation recieved via mobile, cheque , transfer or cash
                var mobilemoney = from mob in donationinfo
                                  where mob.Mode == "Equitel" || mob.Mode== "M-Pesa"
                                  select mob;
                var mobilesum = mobilemoney.Sum(mobilemoney => mobilemoney.Amount);
                mobiletext.Text = $"{mobilesum.ToString():C0} Ksh";


                //donation stats, Cheques, all monies in the bank daomain
                var cheques = from mob in donationinfo
                              where mob.Mode== "Cheque" || mob.Mode=="Credit Card" || mob.Mode=="Debit Card" || mob.Mode=="Funds Transfer"
                              select mob;
                var chequesum = cheques.Sum(cheques => cheques.Amount);
                chequetext.Text = $"{chequesum.ToString():C0} Ksh";

                //donation stats, Cheques
                var cash = from mob in donationinfo
                              where mob.Mode== "Cash"
                              select mob;
                var cashsum = cash.Sum(cash => cash.Amount);
                cashtext.Text = $"{cashsum.ToString():C0} Ksh";

                //var formatedcash = Convert.ToDecimal(cashsum.ToString());



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }








            //try to get a single message from the messages dataset to display in a textbox
            /* 
              try
              {
                  var msgs1 = new Messanger();

                  msgs1 = (Messanger)msgs.Take(1);

                  msgtitle1.Text = msgs1.Title;
                  msgtext1.Text = msgs1.Message;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }*/







            //Seed data used to initialize the database

            IEnumerable<Messanger> message = new List<Messanger>
        {
            new Messanger{ Title = "Custodian Job Vacancy", Message= " Primary duties: A custodian works in the church and its related buildings", Createdon ="08/07/2022", Category="New Job"  },
            new Messanger{ Title = "Announcement", Message= " Primary duties: A custodian works in the church and its related buildings", Createdon ="18/07/2022", Category="New Job"  }
        };

            
            
            //the data source for the events datagrid, it only displays ten items, recently added to the database
            eventsgrid.ItemsSource=recentevent;

        }

      
        //Event handler for the datagrid 
        private void DataGridRow_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var row = e.Source as DataGridRow; 
                EventDetails eventDetails = new EventDetails(row.Item);
                eventDetails.Show();
            }


        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            

        }
    }
}
