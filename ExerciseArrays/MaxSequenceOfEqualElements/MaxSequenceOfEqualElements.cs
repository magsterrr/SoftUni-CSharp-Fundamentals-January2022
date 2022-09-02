using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberOfRepeats = 1;
            int valueBeingRepeated = 0;
            int temporaryNumberOfRepeats = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int temporaryValue = 0;

                if (array[i] == array[i + 1])
                {
                    temporaryNumberOfRepeats++;
                    temporaryValue = array[i];
                }

                if (numberOfRepeats < temporaryNumberOfRepeats)
                {
                    numberOfRepeats++;
                    valueBeingRepeated = temporaryValue;
                }

                if (array[i+1] != array[i])
                {
                    temporaryNumberOfRepeats = 1;
                }
                
            }

            for (int j = 0; j < numberOfRepeats; j++)
            {
                Console.Write($"{valueBeingRepeated} ");
            }
        }
    }
}
