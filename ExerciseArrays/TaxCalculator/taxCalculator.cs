using System;
using System.Linq;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                     .Split(">>", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray()
                     .Select(x => x.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                     .ToArray();

            double totalTaxToPay = 0;
            double collected = 0;

            foreach (var item in input)
            {
                string carType = item[0];
                int yearToBeTaxed = int.Parse(item[1]);
                int kmTraveled = int.Parse(item[2]);

                if (carType != "family" && carType != "heavyDuty" && carType != "sports")
                {
                    Console.WriteLine("Invalid car type.");
                }

                if (carType == "family")
                {
                    totalTaxToPay = kmTraveled / 3000 * 12 + (50 - yearToBeTaxed * 5);
                    Console.WriteLine("A family car will pay {0:F2} euros in taxes.", totalTaxToPay);
                    collected += totalTaxToPay;
                }

                if (carType == "heavyDuty")
                {
                    totalTaxToPay = kmTraveled / 9000 * 14 + (80 - yearToBeTaxed * 8);
                    Console.WriteLine("A heavyDuty car will pay {0:F2} euros in taxes.", totalTaxToPay);
                    collected += totalTaxToPay;
                }

                if (carType == "sports")
                {
                    totalTaxToPay = kmTraveled / 2000 * 18 + (100 - yearToBeTaxed * 9);
                    Console.WriteLine("A sports car will pay {0:F2} euros in taxes.", totalTaxToPay);
                    collected += totalTaxToPay;
                }
            }
            Console.WriteLine("The National Revenue Agency will collect {0:f2} euros in taxes.", collected);
        }
    }
}
