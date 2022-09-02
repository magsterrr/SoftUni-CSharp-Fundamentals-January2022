using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int requestedSum = int.Parse(Console.ReadLine());

            int numberOne = 0;
            int numberTwo = 0;
            int currentSumOfTwo = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = numbers.Length -1; j >= i + 1; j--)
                {
                    currentSumOfTwo = numbers[i] + numbers[j];

                    if (currentSumOfTwo == requestedSum)
                    {
                        numberOne = numbers[i];
                        numberTwo = numbers[j];
                        Console.WriteLine($"{numberOne} {numberTwo}");
                    }
                }
            }
               
        }
    }
}
