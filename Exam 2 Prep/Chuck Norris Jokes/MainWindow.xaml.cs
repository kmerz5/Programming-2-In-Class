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

namespace Chuck_Norris_Jokes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*Go to https://api.chucknorris.io/ (Links to an external site.) and look at the API.  
     * We are going to put a pretty background image (from the internets) for our form of Chuck Norris. 
     * We will allow the user to select any of the provided categories from the API via a ComboBox, they should also have an option of 'All'
     * (that will be the first item listed in the box)  which will just get a joke from any of the categories (hint: will remove that URL parameter).  
     * Once they select an item from the ComboBox, the user will then press a button that will let you know that you should go get a quote from whatever they selected and then display it on the page.
     
     
     GUI
     - background image DONE
     - combox box to select the provided categories DONE
     - button to display quote DONE
     - Textbox to display quote DONE*/
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync("https://api.chucknorris.io/jokes/categories").Result;

                List<string> category = JsonConvert.DeserializeObject<List<string>>(json);

                foreach (var cat in category)
                {
                    cbx_categories.Items.Add(cat);

                }

                
            }
        }
    }
}
