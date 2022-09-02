using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] topIntegers = new int[arr.Length];
            int topIntegersIndex = 0;

            for (int i = 0; i <= arr.Length - 1; i++)
            {
                int currentNum = arr[i];
                bool isTopInteger = true;

                for (int j = i +1 ; j <= arr.Length - 1; j++)
                {
                    int nextNum = arr[j];

                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNum;
                    topIntegersIndex++;
                }
            }
            for (int i = 0; i < topIntegersIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }
         
        }
    }
}
