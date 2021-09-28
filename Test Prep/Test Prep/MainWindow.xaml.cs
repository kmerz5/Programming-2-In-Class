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

namespace Test_Prep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Change the background of your window and the title.
            //Have at least two entries from the user (text boxes) and output some result with the input.
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            string firstname = txt_first.Text;
            string lastname = txt_last.Text;

            string fullname = $"{lastname}, {firstname}";

            lbx_output.Items.Add(fullname);
        }
    }
}
