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

namespace Vowels_and_Consonants__2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
            /*Have a textbox that allows the user to type any word -----DONE----
             There should be an "Enter" button that the user can click once they have input their word ----DONE----
            There should be two list boxes  so that when a user clicks the button, the application will sort all vowels into one list box and all consonants into another list box ----DONE----
            Hint: Look @ the Items property

            The textbox should clear once the user has clicked the "Enter" button ----DONE----
            Both list boxes should clear when the user enters a different word into the textbox*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lbx_vowels.Items.Clear();
            lbx_consonants.Items.Clear();
            string word = txt_word.Text;
            txt_word.Clear();


            for (int i = 0; i < word.Length; i++)
            {
                char letter = word[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    lbx_vowels.Items.Add(letter);

                }
                else
                {
                    lbx_consonants.Items.Add(letter);
                }
                


            }

            
        }
    }
}
