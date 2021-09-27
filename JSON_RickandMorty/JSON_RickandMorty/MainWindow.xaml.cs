using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_RickandMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {
                //make sure the resource is closed off from the internet, not just hanging around
                //creating this variable with this scope - so it makes sure you dispose of that object and dont have a communication channel open
                string jsonData = client.GetStringAsync("https://rickandmortyapi.com/api/character").Result; //gonna copy and paste what we have inside a string
                //syncroness (like waiting for the person with the batton to give it to you before you start
                //Asyncroness (everyone going at the same time and whoever is the slowest looses - we do not do this in this class (but modern web works this way)

                RickandMortyAPI api = JsonConvert.DeserializeObject<RickandMortyAPI>(jsonData);

                //populate combo box
                foreach (Character item in api.results)
                {
                    cbx_dropdown.Items.Add(item);

                }
            }
        }

        private void cbx_dropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Character selected = (Character)cbx_dropdown.SelectedItem;
            lbl_Name.Content = selected.name;
            img_Character.Source = new BitmapImage(new Uri(selected.image));

            

        }
    }
}
