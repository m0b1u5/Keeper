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
    /// Interaction logic for addmember.xaml
    /// </summary>
    public partial class addmember : Window
    {

        //this page allows the user to input data in text boxes and submit the data to the database


        public addmember()
        {
            InitializeComponent();
        }







        //Close Window UI button. It closes the add member window

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }


        //Submit Button

        //When the User inputs the details about a new member, This button submits the data to the database

        //Should add validation constraints to verify the type of data expected for each text input box

        private void SubmitMember(object sender, RoutedEventArgs e)
        {

            //Submit initializes a new instance of the dataContext Class, KeptDb is the name of the databse Context

            var kp = new KeepersDb();



            //a try catch block to catch input errors to prevent the application from cashing incase invalid input is recieved by the data context


            try
            {
                //age and minister are declared as not null in the database so they are initialized to zero and changed by user input




                //these are the variables collected from the input textbox controls, they are parsed to the type expected by the database context

                string names = Nametext.Text.ToString();
                string phones = Phonetext.Text.ToString();
                string addresses = Addresstext.Text.ToString();
                string genders = Gendertext.Text.ToString();
                string memberships = Membershiptext.Text.ToString();
                string emails = Emailtext.Text.ToString();
                string cities = Citytext.Text.ToString();
                string occupations = Occupationtext.Text.ToString();
                
                string families = Familytext.Text.ToString();
                int family = int.Parse(families);


                string ministers = Ministertext.Text.ToString();


                string ages = Agetext.Text.ToString();




                IEnumerable<Person> peeps = new List<Person>
            {
                new Person { Name =names, DOB =ages, Gender=genders, Minister=ministers, Phone=phones, Address=addresses, Email=emails, Status=memberships, City=cities, FamilyID = family, Occupation=occupations }      };

                foreach (Person pe in peeps)
                {
                    kp.people.Add(pe);
                }

                kp.SaveChanges();



                MessageBox.Show($"{names} Added to Members ");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sumbission Failed, Invalid Input");
            }


        }
    }
}
