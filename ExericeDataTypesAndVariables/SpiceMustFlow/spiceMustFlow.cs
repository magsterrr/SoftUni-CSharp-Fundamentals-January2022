using System;

namespace spiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int days = 0;
            int spice = 0;

            while (startingYield >= 100)
            {
                int dailySpice = startingYield;
                int endOfDaySpice = dailySpice;
                if (endOfDaySpice >= 26)
                {
                    endOfDaySpice = endOfDaySpice - 26;
                }
                startingYield = startingYield - 10;
                days = days + 1;
                spice = spice + endOfDaySpice;

            }

            if (startingYield < 100 && days >= 1)
            {
                spice = spice - 26;
            }

            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
