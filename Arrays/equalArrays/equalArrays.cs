﻿using System;
using System.Linq;

namespace equalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            bool arraysAreDifferent = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += secondArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. " +
                        $"Found difference at {i} index");
                    arraysAreDifferent = true;
                    break;
                }
            }
            if (!arraysAreDifferent)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }

        }
    }
}
