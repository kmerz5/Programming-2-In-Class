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

namespace _P__WPF___Contact_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contacts> contact = new List<Contacts>();
        public MainWindow()
        {
            InitializeComponent();
            //creating an array of strings which will read in each line of the file
            string[] filecontents = File.ReadAllLines("contacts.txt");

            for (int i = 1; i < filecontents.Length; i++)
            {
                //foreach line in the array we want to split on the | to get each piece of the data
                string line = filecontents[i];
                string[] pieces = line.Split('|');

                //setting each variable equal to which piece of the data it is equivelant to
                string id = pieces[0];
                double ID = Convert.ToDouble(id);
                string firstname = pieces[1];
                string lastname = pieces[2];
                string email = pieces[3];
                string url = pieces[4];

                //taking those variables created above and putting it into the class Contacts constructor
                Contacts info = new Contacts(ID, firstname, lastname, email, url);
                //adding the contact information to the list box and to the list we created at the very top
                lstbx_contacts.Items.Add(info);
                contact.Add(info);


            }
        }

        

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            //saying that what is selected from the Contacts class is the item selected in the list box
            Contacts selected = (Contacts)lstbx_contacts.SelectedItem;

            //Saying that each of the text boxes will equal the email, firsname, and lastname that was contained in the list
            txt_email.Text = selected.Email;
            txt_First.Text = selected.FirstName;
            txt_last.Text = selected.LastName;

            //using this code to change the photo
            var uri = new Uri(selected.Image);
            var img = new BitmapImage(uri);
            //setting the image.Source equal to the variable img we created above
            img_picture.Source = img;
               

        }
    }
}
