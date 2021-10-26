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

namespace Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*Create a GUI application to allow the user to look through, and filter, the all_games.csv  Download all_games.csvdata set. 

    The user should be able to select the platform from a ComboBox (should be populated from the data and have unique values), All should be a valid option listed at the top as well.  
    The application should load with all the games listed in a ListBox (Format: "{Name}"). 

    When the user selects a different value in the ComboBox, the dataset should update.  If the user double clicks any item in the ListBox, display the details of the game in a NEW WINDOW 
    (Hint: Make a new Window (similar to making a new Class) and when the event is called, make a new instance of the Window you just created and pass in the selected game).  
    There should be a button that when pressed, will take all of the objects inside of the ListBox and serialize them to JSON to a file where the application is being ran named "games.json"*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
