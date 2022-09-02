using System;

namespace sumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int remainder = 0;

            while (n > 0)
            {
                remainder = n % 10;
                sum = sum + remainder;
                n = n / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
