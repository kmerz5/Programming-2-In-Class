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
             * best for the user.*/


            /*Once a student has successfully submitted their information for the handout, add their important 
             * information to a ListBox. When added to the ListBox, it should show the object as follows: “FirstName 
             * LastName, Major, Special Distinction.” (For this homework, lets assume that all students only graduate 
             * with 1 major.) Make sure to add plenty of style! This is a graduation handout, after all.*/
}
}
}
