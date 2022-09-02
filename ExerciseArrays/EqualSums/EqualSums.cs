using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumLeft = 0;
            int sumRight = 0;
            int theElement = 0; 

            for (int i = 0; i < array.Length; i++)
            {
                theElement = i;
                for (int j = i +1; j < array.Length; j++)
                {
                    sumRight += array[j];
                }
                for (int k = i - 1; k >= 0; k--)
                {
                    sumLeft += array[k];
                }
                if (sumLeft == sumRight)
                {
                    Console.WriteLine(theElement);
                    return;
                }
                sumLeft = 0;
                sumRight = 0;
            }
            Console.WriteLine("no");
        }
    }
}
