using System;

namespace _8_25_Methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the method 1
            LineValueForY(2, 4, 6);

            double value1ForY = LineValueForY(.75, 7, 0);
            Console.WriteLine($"y = ({.75}){7} + {0} ==> {value1ForY}");

            int f = Factorial(5);
            Console.WriteLine($"5! = {f.ToString("N0")}");
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">slope of the line</param>
        /// <param name="x">the x-value of the line</param>
        /// <param name="b">The y-intercept of the line</param>
        /// <returns>the y value of the line</returns>
       

        //make sure that the method is inside the class but not the main method
        static double LineValueForY(double m,double x, double b)
        {
            double y;
            y = m * x + b;

            return y;

        }

        /// <summary>
        /// Calculates the factorial for a given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = number; i > 0; i--)
            {
                factorial = factorial * i;

            }
            return factorial;
        }
    }
}
