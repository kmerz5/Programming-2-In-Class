using System;

namespace _8_25_Loops_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int examCount = 0;
            do
            {
                examCount++;
                Console.WriteLine($"Enter your score (as a percent) for Exam {examCount.ToString("N0")} (e.g. 90% = .9");
                sum += Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("do you have another exam score to enter? yes or no >>");
            } while (Console.ReadLine().ToLower() == "yes");

            Console.WriteLine($"Your average exam score is {(sum / examCount).ToString("P")}");
        }
    }
}
