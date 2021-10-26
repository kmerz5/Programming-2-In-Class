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

namespace Homework_4_Problem_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    /*For this problem, you will be using a webservice to get a random video to play.  
     * The webservice can be found at : http://pcbstuou.w27.wh-2.com/webservices/3033/api/random/video (Links to an external site.) . 
     * You will want to have a button to get a random video from the webservice for the user to press as well as a play and stop button.  
     * When the video is playing, the play button should double as a pause button and should change the text to reflect the available option. */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
