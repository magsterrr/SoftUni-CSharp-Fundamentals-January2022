using System;

namespace PartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currentIndex = startIndex; currentIndex <= endIndex; currentIndex++)
            {
                char currentCh = (char)currentIndex;
                Console.Write($"{currentCh} ");

            }

        }
    }
}
