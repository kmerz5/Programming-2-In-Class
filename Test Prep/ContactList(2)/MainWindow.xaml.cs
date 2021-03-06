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

namespace ContactList_2_
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

            /*You are challenged to create a WPF Application so that you can load in your contacts (see file below).
             * 
             * Your application should read in the data ONCE and store it all in a ListBox ----DONE----
             * where the user can select a contact from the ListBox and press a button to see the details about the contact.  
             * You should have labels and textboxes to accurately describe the data as well as the values, do NOT worry about showing the Id as that is just for storage purposes.  
             * Although you will put the values in the Textbox's, the user should NOT be able to change the values (hint: this is a property we talked about on the control).  
             * When the contact is in your ListBox, it should be displayed in the format : "{Lastname}, {Firstname}"

            Do not use a textbox to show the Photo field, instead show the actual image of the contact.*/

            string[] lines = File.ReadAllLines("contacts.txt");
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split('|');

                string id = pieces[0];
                double iD = Convert.ToDouble(id);
                string firstname = pieces[1];
                string lastname = pieces[2];
                string email = pieces[3];
                string photo = pieces[4];

                Contact information = new Contact(iD, firstname, lastname, email, photo);
                
                lbx_contacts.Items.Add(information);
                contactS.Add(information);


            }
        }

        private void btn_details_Click(object sender, RoutedEventArgs e)
        {
            //we want to find the contact in our list and find their information
            Contact selecter = (Contact)lbx_contacts.SelectedItem;
            txt_email.Text = selecter.Email;
            txt_first.Text = selecter.FirstName;
            txt_last.Text = selecter.LastName;

            var uri = new Uri(selecter.Photo);
            var img = new BitmapImage(uri);

            img_contact.Source = img;
        }
    }
}
