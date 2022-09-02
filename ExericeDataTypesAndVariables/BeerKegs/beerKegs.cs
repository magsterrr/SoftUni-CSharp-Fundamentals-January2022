using System;
using System.Numerics;

namespace beerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float biggestVolume = float.MinValue;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                float currVolume = MathF.Pow(radius, 2) * MathF.PI * height;

                if (currVolume >= biggestVolume)
                {
                    biggestVolume = currVolume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
