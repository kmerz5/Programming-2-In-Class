using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace GOT2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

/*Create a Game of Thrones (GOT) WPF Application.  
 * You should have an image from the show as your background as well as a button that will go get a random GOT quote from a web service and display the quote on the screen as well as who said it.
 * 
The random quote can be found by going to https://got-quotes.herokuapp.com/quotes (Links to an external site.)

There should be a different button that when pressed (maybe named Export?), will save all of the jokes that the user got to a file on their computed named GOT_Quotes.json .  
So if the user randomly generated 15 random quotes, your file will have 15 quotes in it.*/
public partial class MainWindow : Window
{
        List<GOTQUOTE> allquotes = new List<GOTQUOTE>();
        List<string> randomquotes = new List<string>();
    public MainWindow()
    {
        InitializeComponent();
    }

        private void btn_getquote_Click(object sender, RoutedEventArgs e)
        {
            

            using (var client = new HttpClient())
            {
                var response = client.GetAsync("https://got-quotes.herokuapp.com/quotes").Result;
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    GOTQUOTE quote = JsonConvert.DeserializeObject<GOTQUOTE>(json);
                    allquotes.Add(quote);

                }

            }

            foreach (var item in allquotes)
            {
                txt_quote.Text = item.quote;
                txt_character.Text = item.character;
                randomquotes.Add(item.ToString());



            }
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            string json = JsonConvert.SerializeObject(randomquotes);
            File.WriteAllText("GOT_Quotes.Json", json);
        }
    }
}
