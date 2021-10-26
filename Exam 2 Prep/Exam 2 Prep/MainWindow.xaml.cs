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

namespace Exam_2_Prep
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
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
