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

namespace Homework_4_Problem_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    /*For this problem, you will be using a webservice to get a random image of a dog breed.  
     * The documentation for the API can be found at https://dog.ceo/dog-api/documentation/ (Links to an external site.).
    You will use https://dog.ceo/api/breed/cattledog/images/random (Links to an external site.) to get a random image for a specific breed of dog. For example, 
    if you wanted to output an image of an Australian Cattledog, you would need to replace “cattledog” with “cattledog/australian”.
    You will need to design your WPF application for the user to type in the dog breed they want to get an image for, e.g. cattledog or cattledog-australian. 
    The user will then press a button and you will take their input and call the webservice above to output an image of the breed specified by the user. 
    You will need to read the response and make sure they typed in a valid breed (make sure the web service found a breed).  If they did not, tell them to please enter a valid dog breed and 
    clear out the textbox that they typed the breed into. If it was a valid breed and you got a success back, you should display the image using the URL for the image from the response.*/
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
