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

namespace Homework_6_Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*You will be creating a GUI to allow the user to filter down their data set and then export all the data as a .json file format.  
     * Add the car_sales.csv  Download car_sales.csvfile to your project and then let the user select between all the unique color options that exist in the cars
     * (or have the option to select All) from a ComboBox.  Also, allow the user to type in a value for a year as well as a whether they want all sales Equal to, Less than or Equal to, 
     * or Greater than or Equal to the year they entered (e.g. If they entered 2005 and Less than or Equal to, you would filter out any car for a sale that is 2006 or newer). 
     * When the user presses a button, take all of the input from the user into account and filter out the results and add all of the records that match the criteria to a ListBox 
     * (Sales should be displayed as "{Year} {Make} - {Model}").  Below the ListBox, have a label that shows the number of items displayed in the ListBox.  Wherever you think it is appropriate, 
     * place a button to export the contents of the ListBox to a file named Car_Sales.json in the directory where the application is running.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
