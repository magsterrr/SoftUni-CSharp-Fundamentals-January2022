using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rotationsCount = int.Parse(Console.ReadLine());
            int rotationsReducedCount = rotationsCount % arr.Length; // защото ако го завъртим същия брой пъти, колкото елемента има той остава същия

            for (int rotations = 1; rotations <= rotationsReducedCount; rotations++)
            {
                int firstElement = arr[0]; // за да не загубим първия елемент при презаписването
                for (int i = 0; i <= arr.Length -2; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = firstElement;
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
