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

namespace HW_1___Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<TVShow> TVShows = new List<TVShow>();
        private char[] CharactersToTrim = { ' ', '"' };
        public MainWindow()
        {
            InitializeComponent();
            /*In Problem 1, you will read in the TV Show Dataset provided and create a WPF application to filter the data based on various combo boxes on your application. You will create three combo boxes on 
             * your WPF application – one to display TV age ratings (rated), one for the TV show's country, and one for the TV show’s language.  Only display unique values in the combo box for filtering (e.g. 
             * values should not repeat).*/

            var lines = File.ReadAllLines("TV Show Data.txt").Skip(1);
            //need to go through each line of the data - then storing it in the TVShows list
            //foreach(type new variable in collection)
            foreach (var line in lines)
            {
                TVShows.Add(new TVShow(line));

            }

            PopulateListBox(TVShows);
            PopulateRatingFilter();
            PopulateCountryFilter();
            PopulateLanguageFilter();

        }

        private void PopulateLanguageFilter()
        {
            foreach (var show in TVShows)
            {
                string[] values = show.Language.Split(',');
                foreach (var val in values)
                {
                    if (string.IsNullOrWhiteSpace(val))
                    {
                        continue;

                    }

                    string cleanedValue = val.Trim(CharactersToTrim);
                    if (!cbx_language.Items.Contains(cleanedValue))
                    {
                        cbx_language.Items.Add(cleanedValue);

                    }

                }

            }
        }

        private void PopulateCountryFilter()
        {                               //we wanna go through the list
            foreach (var show in TVShows)
            {
                var values = show.Country.Split(',');
                //we need to split on the , because there are multiple countries in one line


                foreach (var val in values)
                {
                    if (string.IsNullOrWhiteSpace(val))
                    {
                        continue;
                    }

                    string cleanedValue = val.Trim(CharactersToTrim);
                    if (!cbx_country.Items.Contains(cleanedValue))
                    {
                        cbx_country.Items.Add(cleanedValue);

                    }

                }

            }
        }

        private void PopulateRatingFilter()
        {
            //Wanting to populate the dropdown with all the possible ratings, without repeating
            foreach (var show in TVShows)
            {
                if (string.IsNullOrWhiteSpace(show.Rated))
                {
                    //basically saying that if the rating is null or white space to keep filtering through all the lines
                    continue;
                }

                //This basically trims the value of anything and then if the combo box doesnt already contain the rated value then it will add it, therefore avoiding repeats (this is what the ! is for)
                string cleanedValue = show.Rated.Trim();//trimming the value of any unwanted punctuation (the trim statement is at the top)
                if (!cbx_rated.Items.Contains(cleanedValue))
                {
                    cbx_rated.Items.Add(cleanedValue);

                }

            }
        }

        private void PopulateListBox(List<TVShow> tVShows)
        {                                           //new variable that it created for us
            //We want to populate the listbox on our xaml with all of the information about the movies
            foreach (var show in tVShows)
            {                       //using that new variable
                    lbx_output.Items.Add(show);
            }
        }
    }
}
