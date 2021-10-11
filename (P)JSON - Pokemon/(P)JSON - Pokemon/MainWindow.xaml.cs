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

namespace _P_JSON___Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PokemonInfo pokemon;
        public MainWindow()
        {
            InitializeComponent();

            string url = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1200";

            using (var client = new HttpClient())
            {
                var response = client.GetAsync(url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    PokemonApi api = JsonConvert.DeserializeObject<PokemonApi>(json);

                    foreach (var resultItem in api.results)
                    {
                        cbx_pokemon.Items.Add(resultItem);
                    }

                }



                

            }
        }

        private void cbx_pokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Data selected = (Data)cbx_pokemon.SelectedItem;
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(selected.url).Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;

                    PokemonInfo pokemon = JsonConvert.DeserializeObject<PokemonInfo>(json);
                    img_pokemon.Source = new BitmapImage(new Uri(pokemon.sprites.front_default));
                }

            }
        }
        //GO LOOK AT GITHUB FOR THE REST OF THE CODE!!!!!
        private void btn_Toggle_Click(object sender, RoutedEventArgs e)
        {
            img_pokemon.Source = new BitmapImage(new Uri(pokemon.sprites.back_default));


        }
    }
}
