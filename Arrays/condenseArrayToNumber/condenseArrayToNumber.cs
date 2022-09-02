using System;
using System.Linq;

namespace condenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            int firstLength = array.Length;

            //кондензиране на масив
            // 1 2 3
            // 3 4
            // 8
            //lenght - 1 за да не продължи да събира след 3

            for (int i = 0; i < firstLength - 1 ; i++)
            {
                int[] condensed = new int[array.Length - 1];

                for (int j = 0; j < array.Length - 1; j++)
                {
                    condensed[j] = array[j] + array[j + 1];
                }
                array = condensed;
            }
            Console.WriteLine(array[0]);  
        }
    }
}
