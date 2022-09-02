using System;
using System.Linq;

namespace TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                .Split(',',' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string priceType = Console.ReadLine();
            int sumLeft= 0;
            int sumRight = 0;
            string direction = string.Empty;

            //left
            for (int i = entryPoint - 1; i >= 0 ; i--)
            {
                int entryPointValue = priceRatings[entryPoint];

                if (priceType == "expensive" && priceRatings[i] >= entryPointValue)
                {
                    sumLeft += priceRatings[i];
                }
                else if (priceType == "cheap" && priceRatings[i] < entryPointValue)
                {
                    sumLeft += priceRatings[i];
                }
            }
            //right
            for (int i = entryPoint + 1; i <= priceRatings.Length - 1; i++)
            {
                int entryPointValue = priceRatings[entryPoint];

                if (priceType == "expensive" && priceRatings[i] >= entryPointValue)
                {
                    sumRight += priceRatings[i];
                }
                else if (priceType == "cheap" && priceRatings[i] < entryPointValue)
                {
                    sumRight += priceRatings[i];
                }
            }

            if(sumLeft >= sumRight)
            {
                direction = "Left";
                Console.WriteLine(direction + " - " + sumLeft);
            }
            else if(sumRight > sumLeft)
            {
                direction = "Right";
                Console.WriteLine(direction + " - " + sumRight);
            }

        }
    }
}
