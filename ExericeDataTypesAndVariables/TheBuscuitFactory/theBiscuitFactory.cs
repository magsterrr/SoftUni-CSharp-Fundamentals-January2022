using System;

namespace TheBuscuitFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDayPerWorker = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int productionOfOtherFactory = int.Parse(Console.ReadLine());

            double lowerProductivityProductionPerDay = Math.Floor((biscuitsPerDayPerWorker * workers) * 0.75);
            int productionWithFullProductivity = (biscuitsPerDayPerWorker * workers) * 20;
            double productionWithLowerProductivity = lowerProductivityProductionPerDay * 10;
            double totalProduction = productionWithLowerProductivity + productionWithFullProductivity;

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");

            if (totalProduction > productionOfOtherFactory)
            {
                double difference = totalProduction - productionOfOtherFactory;
                double percentage = (difference / productionOfOtherFactory) * 100;
                Console.WriteLine("You produce {0:F2} percent more biscuits.", percentage);
            }
            if (productionOfOtherFactory > totalProduction)
            {
                double difference = productionOfOtherFactory - totalProduction;
                double percentage = (difference / productionOfOtherFactory) * 100;
                Console.WriteLine("You produce {0:F2} percent less biscuits.", percentage);
            }
        }
    }
}
