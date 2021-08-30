using System;
using System.Collections.Generic;

namespace _8_30_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fruits =new Dictionary<string, double>();
            fruits.Add("Apples", 0.99);
            //Add the other fruits

            Console.WriteLine("What fruit do you8 want a price of? >>");
            string fruit = Console.ReadLine();

            if (fruits.ContainsKey(fruit) == true)
            {
                Console.WriteLine($"{fruit}'s cost {fruits[fruit]}");
            }
            else
            {
                Console.WriteLine($"Sorry we do not carry {fruit}'s");
            }

        }
    }
}
