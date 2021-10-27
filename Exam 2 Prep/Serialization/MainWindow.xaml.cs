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

namespace Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*Create a GUI application to allow the user to look through, and filter, the all_games.csv  Download all_games.csvdata set. 

    The user should be able to select the platform from a ComboBox (should be populated from the data and have unique values),
    All should be a valid option listed at the top as well.  
    The application should load with all the games listed in a ListBox (Format: "{Name}"). 

    When the user selects a different value in the ComboBox, the dataset should update.  If the user double clicks any item in the ListBox, display the details of the game in a NEW WINDOW 
    

    (Hint: Make a new Window (similar to making a new Class) and when the event is called, make a new instance of the Window you just created and pass in the selected game).  
    There should be a button that when pressed, will take all of the objects inside of the ListBox and serialize them to JSON to a file where the application is being ran named "games.json"
    
     GUI
     - Combo box for the platform
     - Listbox with all the games*/

    public partial class MainWindow : Window
    {

        List<Game> allgames = new List<Game>();
        public MainWindow()
        {
            InitializeComponent();
            cbx_platforms.Items.Add("All");

            string[] lines = File.ReadAllLines("all_games (1).csv").Skip(1).ToArray();

            foreach (var line in lines)
            {
                string[] pieces = line.Split(",");

                string name = pieces[0];
                
                string platform = pieces[1];
                string release_date = pieces[2];
                string summary = pieces[3];
                string meta_score = pieces[4];
                double Meta_Score = Convert.ToDouble(meta_score);
                string user_review = pieces[5];

                Game games = new Game(name, platform, release_date, summary, Meta_Score, user_review);
                allgames.Add(games);

                if (cbx_platforms.Items.Contains(games.platform) == false)
                {
                    cbx_platforms.Items.Add(games.platform);

                }
               

            }

        }

        private void cbx_platforms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbx_games.Items.Clear();
            string selectedplatform = cbx_platforms.SelectedItem.ToString();
            foreach (var gamename in allgames)
            {
                if (selectedplatform == "All")
                {
                    lbx_games.Items.Add(gamename);

                }
                else if (gamename.platform == selectedplatform)
                {

                    lbx_games.Items.Add(gamename);

                }

            }
        }

        

        private void lbx_games_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            Game selected = (Game)lbx_games.SelectedItem;

            if (selected is null)
            {
                return;
            }

            WindowDetails wd = new WindowDetails();
            wd.SetData(selected);
            wd.ShowDialog();

        }
    }
}
