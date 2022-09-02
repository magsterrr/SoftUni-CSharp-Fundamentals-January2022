using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int pokes = 0;
            double tired = n;

            while (n >= m )
            {
                pokes = ++pokes;
                n = n - m;

                if (tired/2  == n && y != 0)
                {
                    n = n / y;
                }
            }

             Console.WriteLine(n);
             Console.WriteLine(pokes);
        }
        
    }
}
