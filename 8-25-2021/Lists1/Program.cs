using System;
using System.Collections.Generic;

namespace Lists1
{
    class Program
    {
        static void Main(string[] args)
        {
            //click the light bulb and we want the using system

            List<double> examGrades = new List<double>();

            bool shouldContinue = true;
            while (shouldContinue)
            {
                Console.WriteLine("Please enter your exam grade >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                examGrades.Add(grade);

                Console.WriteLine("Do you want to enter another grade? Yes or No >>");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    shouldContinue = false;
                }
            }

            double avg, sum = 0;

            foreach (double grade in examGrades)
            {
                sum += grade;

            }

            avg = sum / examGrades.Count;
            Console.WriteLine($"The average of your exam grades is {avg.ToString("P2")}");
        }
    }
}
