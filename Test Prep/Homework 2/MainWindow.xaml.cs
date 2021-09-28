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

namespace Homework_2
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

        private void btn_submitinfo_Click(object sender, RoutedEventArgs e)
        {
            /*After they have input all this information and click a button to submit their information, validate 
            * that all information provided by the user meets the data type associated with it (e.g. ints should be
            * whole numbers, strings should not be empty, etc.). If any of the information is invalid, do not add the
            * student to the handout and notify the user of ALL incorrect information, in whatever way you think is
            * best for the user.*/ //DONE

            //Create a boolean to see if all of the data types are entered correctly
            bool validation = true;

            //validation for all the strings
            if (string.IsNullOrWhiteSpace(txt_first.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid first name");
            }

            if (string.IsNullOrWhiteSpace(txt_last.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid last name");
            }

            if (string.IsNullOrWhiteSpace(txt_major.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid major name");
            }

            if (string.IsNullOrWhiteSpace(txt_stname.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid street name");
            }

            if (string.IsNullOrWhiteSpace(txt_city.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid city");
            }

            if (string.IsNullOrWhiteSpace(txt_state.Text) == true)
            {
                validation = false;
                MessageBox.Show("You must enter a valid state");
            }

            //validation for the doubles/int street# int/ GPA double/ Zipcode int
            int streetnumber;
            if (int.TryParse(txt_number.Text, out streetnumber) == false)
            {
                validation = false;
                MessageBox.Show("You must enter a valid street number");

            }

            int zipcode;
            if (int.TryParse(txt_zcode.Text, out zipcode) == false)
            {
                validation = false;
                MessageBox.Show("You must enter a valid zipcode");

            }

            double gpa;
            if (double.TryParse(txt_gpa.Text, out gpa) == false)
            {
                validation = false;
                MessageBox.Show("You must enter a valid GPA");

            }
            if (validation == false)
            {
                return;
            }


            /*Once a student has successfully submitted their information for the handout, add their important 
             * information to a ListBox. When added to the ListBox, it should show the object as follows: “FirstName 
             * LastName, Major, Special Distinction.” (For this homework, lets assume that all students only graduate 
             * with 1 major.) Make sure to add plenty of style! This is a graduation handout, after all.*/

            //set all the textbox text equal to a variable
            string firstname = txt_first.Text;
            string lastname = txt_last.Text;
            string major = txt_major.Text;
            double Gpa = gpa;
            
            Student student = new Student(firstname, lastname, major, Gpa);
            student.SetAddress(streetnumber, txt_stname.Text, txt_state.Text, txt_city.Text, zipcode);
            lstbx_output.Items.Add(student);

            
            

        }
}
}
