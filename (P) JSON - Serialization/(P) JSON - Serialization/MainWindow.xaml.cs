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

namespace _P__JSON___Serialization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Games> games = new List<Games>();
        List<string> platforms = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            //populate the combo box with the platforms
            string[] lines = File.ReadAllLines("all_games(1).csv");
            Games game1 = new Games();
            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] pieces = line.Split(',');

              
                string name = pieces[0];
                string platform = pieces[1];
                string release_date = pieces[2];
                string summary = pieces[3];
                string meta_score = pieces[4];
                int gamemeta_score = Convert.ToInt32(meta_score);
                string user_review = pieces[5];
                

                Games information = new Games(name, platform, release_date, summary, gamemeta_score, user_review);
                games.Add(information);

                //populate the combobox
                    if (cbx_platform.Items.Contains(information.platform) == false)
                    {
                        cbx_platform.Items.Add(information.platform);

                    }

                lbx_games.Items.Add(information);

                
                

            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPlatform = cbx_platform.Text;
            //GO LOOK AT HIS CODE IN GITHUB TO GET A BETTER IDEA AS YOURS IS MISMATCHED WITH HIS AND DOES NOT MAKE SENSE  
        }
    }
}
