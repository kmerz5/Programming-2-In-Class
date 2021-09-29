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
            lbx_output.Items.Clear();
            foreach (var show in tVShows)
            {                       //using that new variable
                    lbx_output.Items.Add(show);
            }
        }


        /*Each combo box should allow the user to select a value to filter the TV shows. 
         * Once a user selects a value from any combo box, the titles pertaining to that value should display in a list box on your application. 
         * The user should be able to select a single title from the list box and view the poster image and plot description for the show. 
         * Below there is code to populate this information in a new window, however, you can display this information on the same GUI if you would like. 
         * Make sure to add the TXT (that is tab-delimited) file to your project and reference it relatively in your code (don't put the full path to where it only works on your computer).*/
        private void cbx_rated_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDateForFilters();

        }


        private void UpdateDateForFilters()
        {
            //basically what we need to do is to take what is selected from the combo box, after that we need to filter through the entire list of Tvshows
            //if the data contains that filter then it will output all the information about the TVshow into the listbox

            //this is saying if any of these values in the combo box are null - then to return (stop the program)
            if (cbx_country.SelectedValue is null 
                || cbx_language.SelectedValue is null
                ||cbx_rated.SelectedValue is null)
            {
                return;
            }


            //This is basically creating a new list called filtered shows
            List<TVShow> filteredShows;
            //this is setting the new list of filtered shows to the filtered ratings of the original TVshows list
            filteredShows = FilterRating(TVShows);
            //this is now setting the list of filtered shows to the filtered list after already filtering ratings
            filteredShows = FilterCountry(filteredShows);
            //this is now setting the list of filtered shows to the filtered list after already filtering ratings and country
            filteredShows = FilterLanguage(filteredShows);

            //then we want to repopulate the listbox
            PopulateListBox(filteredShows);
            
        }

        private List<TVShow> FilterLanguage(List<TVShow> shows)
        {
            string language = cbx_language.SelectedItem.ToString();
            List<TVShow> filteredShows = new List<TVShow>();

            foreach (var show in shows)
            {
                if (language.ToLower() == "all")
                {
                    filteredShows.Add(show);

                }
                else if (show.Language.Contains(language))
                {
                    filteredShows.Add(show);

                }

            }
            return filteredShows;
        }

        private List<TVShow> FilterCountry(List<TVShow> shows)
        {
            string country = cbx_country.SelectedValue.ToString();

            List<TVShow> filteredShows = new List<TVShow>();
            foreach (var show in shows)
            {
                if (country.ToLower() == "all")
                {
                    filteredShows.Add(show);
                   
                }
                else if (show.Country.Contains(country))
                {
                    filteredShows.Add(show);

                }

            }
            return filteredShows;
        }

        private List<TVShow> FilterRating(List<TVShow> shows)
        {
            //turning the rating selected into a string
            string rating = cbx_rated.SelectedValue.ToString();

            //creating a new list within TVShow that is called filteredShows
            List<TVShow> filteredShows = new List<TVShow>();

            //going through each show in the list of shows - if the selection is "all" it is gonna add all shows. If not, then it is checking to see if the data contains that rating, if so, adding the show
            foreach (var show in shows)
            {
                if (rating.ToLower() == "all")
                {
                    filteredShows.Add(show);

                }
                else if (show.Rated.Contains(rating))
                {
                    filteredShows.Add(show);

                }

            }
            return filteredShows;
        }

        private void cbx_country_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDateForFilters();
        }

        private void cbx_language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDateForFilters();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TVShow selected = (TVShow)lbx_output.SelectedItem;

            var uri = new Uri(selected.Poster);
            var img = new BitmapImage(uri);

            img_poster.Source = img;
        }
    }
}
