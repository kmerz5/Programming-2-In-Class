using System;
using System.Collections.Generic;
using System.IO;
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

namespace Things_to_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contactS = new List<Contact>();
        public MainWindow()
        {
            InitializeComponent();


            //How to create a list n(above)^^^^

            //reading in a file and splitting that file
            /* string[] filecomponents = File.ReadAllLines("contacts.txt");

             for (int i = 1; i < filecomponents.Length; i++)
             {
                 string file = filecomponents[i];
                 string[] pieces = file.Split('|');*/




            string[] filecontents = File.ReadAllLines("contacts.txt");
            for (int i = 1; i < filecontents.Length; i++)
            {
                string line = filecontents[i];
                string[] pieces = line.Split('|');

            

                string id = pieces[0];
                double ID = Convert.ToDouble(id);
                string firstname = pieces[1];
                string lastname = pieces[2];
                string email = pieces[3];
                string photo = pieces[4];

                //LOOK AT THIS LINE - HAVE TO CREATE A VARIABLE AND THEN CREATE THE NEW INSTANCE OF THE CLASS
                Contact information = new Contact(ID, firstname, lastname, email, photo);
                lbx_contacts.Items.Add(information);
                contactS.Add(information);

                

            }

            

        }


        //using the item selected in the listbox (contacts)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Contact selected = (Contact)lbx_contacts.SelectedItem;
            tb1.Text = selected.FirstName;
            tb2.Text = selected.LastName;
            tb3.Text = selected.Email;

            var uri = new Uri(selected.Photo);
            var img = new BitmapImage(uri);

            img_picture.Source = img;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //make sure that things that are input are verified as the correct datatype do a string and a double
            bool validation = true;
            if (string.IsNullOrEmpty(txt_word.Text) == true)
            {
                MessageBox.Show("You must enter a valid word");
                validation = false;


            }
            double number;
            if (double.TryParse(txt_double.Text, out number) == false) 
            {
                MessageBox.Show("You must enter a valid number");
                validation = true; 

            }

        }
    }
}
