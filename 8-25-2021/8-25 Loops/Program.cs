using System;

namespace _8_25_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double exam1 = 0, exam2 = 0, exam3 = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please enter your grade for Exam {i + 1}");
                string answer = Console.ReadLine();
                switch (i)
                {
                    case 0:
                        exam1 = Convert.ToDouble(answer);
                        break;
                    case 1:
                        exam2 = Convert.ToDouble(answer);
                        break;
                    case 2:
                        exam3 = Convert.ToDouble(answer);
                        break;
                    default:
                        break;

                }

            }

            double sum = exam1 + exam2 + exam3;
            double avg = sum / 3;
            avg /= 100;
            Console.WriteLine($"The Average of your exam grades is {avg.ToString("P2")}");
            

          

        }
    }
}
