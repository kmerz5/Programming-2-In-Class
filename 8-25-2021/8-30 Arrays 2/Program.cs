using System;

namespace _8_30_Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lowercaseLetters = { 'a', 'b', 'c', 'd' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D' };

            string firstName = "" + uppercaseLetters[0] + lowercaseLetters[3];
            firstName = uppercaseLetters[0].ToString() + lowercaseLetters[3].ToString();

            Console.WriteLine(firstName);
        }
    }
}
