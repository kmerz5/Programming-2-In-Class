using System;

namespace _8_30_21_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays 1
            string[] fruits = new string[5];
            fruits[0] = "Apples";
            fruits[1] = "Oranges";
            fruits[2] = "Bananas";
            fruits[3] = "Grapes";
            fruits[4] = "Blueberries";

            double[] prices = { .99, 0.50, 0.50, 2.99, 1.99 };

            Console.WriteLine("What fruit would you like to find the price of? >>");
            string fruit = Console.ReadLine();

            int indexOfFruit = -1; //-1 because I could let them define the fruit but we will never have the value of -1

            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == fruit)
                {
                    indexOfFruit = i;
                    break;
                }
            }

            if(indexOfFruit >= 0)
            {
                Console.WriteLine($"{fruit}'s cost {prices[indexOfFruit].ToString("C2")}");
            }
            else
            {
                Console.WriteLine($"Sorry, we do not carry {fruit}'s");
            }

        }
    }
}
