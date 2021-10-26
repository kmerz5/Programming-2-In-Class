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

namespace Homework_6_Problem_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /*You will be creating a GUI to allow the user to discover new wines!  
     * Allow the user to filter down the Wines by Country or Price (when they enter the Price, it is a FAIR ASSUMPTION that they mean that price or lower when filtering the results).  
     * The API for the wine dataset can be found at http://pcbstuou.w27.wh-2.com/webservices/3033/api/Wine/Reviews (Links to an external site.) .  Please note, there is a lot of data, 
     * so for testing purposes you might want to limit your result set down by adding a query parameter on the end named number with the # of records you want back 
     * (e.g. http://pcbstuou.w27.wh-2.com/webservices/3033/api/Wine/Reviews?number=100 (Links to an external site.) ).  The user is not super familiar with Wine's so make sure that they have 
     * options to choose from for the Country (e.g. listbox, combobox, something else!).  Allow the user to press a button to filter the results of the Wine's that are displayed in a ListBox 
     * (format: "{Title}").  The user should be able to press a button to export whatever wine's are in the ListBox to a file named wines.json in the directory where the application is running.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
