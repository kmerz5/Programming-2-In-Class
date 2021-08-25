using System;

namespace _8_25_2021
{
    class Program
    {
        const double COG_COST = 79.99;
        const double GEAR_COST = 250.00;
        const double FULL_MARKUP_PERCENT = .15;
        const double DISCOUNT_MARKUP_PERCENT = .125;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Non-Procedural Programming Sales Department");
            Console.WriteLine("How many cogs do you want to purchase? >>");
            string answer = Console.ReadLine();

            int cogs, gears;

            if (int.TryParse(answer, out cogs) == false)
            {
                Console.WriteLine("Invalid number for cogs. Goodbye");
                Environment.Exit(1);
            }



            Console.WriteLine("How many gears do you want to purchase? >>");
            answer = Console.ReadLine();

            if (int.TryParse(answer, out gears) == false)
            {
                Console.WriteLine("Invalid number for gears. Goodbye");
                Environment.Exit(1);
            }

            double totalCost, discountAmount, taxAmount;
            totalCost = (cogs * COG_COST) + (gears * GEAR_COST);


            //deciding the markup
            //can also do 
            //if (cogs >=10 || gears >=10 || (gears +cogs) >= 16)
            // {
            //  markupPercent = DISCOUNT
            //}
            //else
            //markupPercent = FULL

            double markupPercent;
            if (cogs >= 10)
            {
                markupPercent = DISCOUNT_MARKUP_PERCENT;

            }
            else if (gears >= 10)
            {
                markupPercent = DISCOUNT_MARKUP_PERCENT;

            }
            else
            {
                if (gears + cogs >= 16)
                {
                    markupPercent = DISCOUNT_MARKUP_PERCENT;

                }
                else
                {
                    markupPercent = FULL_MARKUP_PERCENT;
                }
            }

            discountAmount = totalCost * FULL_MARKUP_PERCENT - totalCost * DISCOUNT_MARKUP_PERCENT;

            Console.WriteLine($"Cogs @ {COG_COST.ToString("C")} * {cogs.ToString("N0")} = {(cogs * COG_COST).ToString("C")}");
            Console.WriteLine($"Cogs @ {GEAR_COST.ToString("C")} * {gears.ToString("N0")} = {(gears * GEAR_COST).ToString("C")}");
            Console.WriteLine($"Total Cost: {totalCost.ToString("C")}");
            Console.WriteLine($"Discount: {discountAmount.ToString("C")}");
        }
    }
}
