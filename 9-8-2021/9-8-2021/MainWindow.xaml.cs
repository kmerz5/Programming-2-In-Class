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

namespace _9_8_2021
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void btn_enter_Click(object sender, RoutedEventArgs e)
        {
            lbx_vowels.Items.Clear();
            lbx_Consonants.Items.Clear();
            
            string word = txt_AnyWord.Text;

            char[] chars = new char[word.Length - 1];
            for (int i = 0; i < chars.Length - 1; i++)
            {
                chars[i] = word[i];
            }

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' | chars[i] == 'e' | chars[i] == 'i' | chars[i] == 'o' | chars[i] == 'u')
                {
                    lbx_vowels.Items.Add(chars[i]);

                }
                else
                {
                    lbx_Consonants.Items.Add(chars[i]);

                }

                

            }
            txt_AnyWord.Clear();

        }
    }
}
