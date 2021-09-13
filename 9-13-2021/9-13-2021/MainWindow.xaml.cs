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

namespace _9_13_2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
            //make sure this happens on button click
        {
            string id, fname, lname, gpa, probation, balance;
            id = txt_id.Text;
            fname = txt_fname.Text;
            lname = txt_lname.Text;
            gpa = txt_gpa.Text;
            balance = txt_balance.Text;
            probation = txt_probation.Text;

            Student stud = new Student(Convert.ToInt32(id), fname, lname, Convert.ToDouble(balance));
            stud.GPA = Convert.ToDouble(gpa);
            if (probation.ToLower() == "yes")
            {
                stud.IsOnProbation = true;

            }
            else
            {
                stud.IsOnProbation = false;
            }

        }
    }
}
