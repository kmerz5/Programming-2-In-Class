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

namespace _P_JSON___Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cbx_categories.Items.Add("All");
            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;


                List<string> categories = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (string cat in categories)
                {
                    cbx_categories.Items.Add(cat);

                }
                
            }
            
        }

        private void btn_joke_Click(object sender, RoutedEventArgs e)
        {
            string selected = cbx_categories.SelectedItem.ToString();

            if (selected == "All")
            {
                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync("https://api.chucknorris.io/jokes/random").Result;

                    Joke rand = JsonConvert.DeserializeObject<Joke>(json);
                    txt_joke.Text = rand.value;

                   

                }


            }
            else
            {
                string cat = cbx_categories.Text;
                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync("https://api.chucknorris.io/jokes/random?category=" + cat).Result;

                    Joke rand1 = JsonConvert.DeserializeObject<Joke>(json);
                    txt_joke.Text = rand1.value;



                }

            }
            

            

        }
    }
}
