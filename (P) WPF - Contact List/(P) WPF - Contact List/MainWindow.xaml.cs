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
        public MainWindow()
        {
            InitializeComponent();

            /*string[] fileContents = File.ReadAllLines(fileLocation);

            for (int i = 1; i < fileContents.Length; i++)
            {
                string line = fileContents[i];

                string[] pieces = line.Split(',');

                string paymentType = pieces[3];*/

            string[] fileContents = System.IO.File.ReadAllLines("contacts.txt");

            for (int i = 1; i < fileContents.Length; i++)
            {
                string line = fileContents[i];
                string[] pieces = line.Split('|');

                string id = pieces[0];
                double ID = Convert.ToDouble(id);
                string firstName = pieces[1];
                string lastName = pieces[2];
                string email = pieces[3];
                string photo = pieces[4];

                Contact information = new Contact(ID, firstName, lastName, email, photo);
                lstbx_output.Items.Add(information);

            }
            }

        private void btn_ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            //want to find that is selected in the listbox, take that item and file through
            //the list and find that name - then output the information about that person
            //pieces[1] - FN
            //pieces[2] - LN
            //pieces[3] - Email
            //pieces[4] - photo URL

            string item = lstbx_output.SelectedItem.ToString();
            string[] fullname = item.Split(',');
            txt_FirstName.Text = fullname[1];
            txt_LastName.Text = fullname[0];


        }
    }
}
