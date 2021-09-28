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

namespace _P_WPF___Vowels_and_Consonants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Create a WPF Application with the following criteria:
            Have a textbox that allows the user to type any word - DONE
            There should be an "Enter" button that the user can click once they have input their word - DONE
            There should be two list boxes (Links to an external site.) so that when a user clicks the button, the application will sort all vowels into one list box and all consonants into another list box
            Hint: Look @ the Items property
            The textbox should clear once the user has clicked the "Enter" button
            Both list boxes should clear when the user enters a different word into the textbox */
        }

        private void btn_inputword_Click(object sender, RoutedEventArgs e)
        {
            lstbx_vowels.Items.Clear();
            lstbx_consonants.Items.Clear();

            string word = txt_userinput.Text;

            //create an array of characters which will be from the word the user entered
            char[] chars = new char[word.Length - 1];

            for (int i = 0; i < chars.Length-1; i++)
            {
                chars[i] = word[i];

            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' | chars[i] == 'e' | chars[i] == 'i' | chars[i] == 'o' | chars[i] == 'u')
                {
                    lstbx_vowels.Items.Add(chars[i]);

                }
                else
                {
                    lstbx_consonants.Items.Add(chars[i]);
                }
                

            }
            txt_userinput.Clear();
        }
    }
}
