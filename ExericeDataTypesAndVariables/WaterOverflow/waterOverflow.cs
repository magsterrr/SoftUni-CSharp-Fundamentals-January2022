using System;

namespace waterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int lines = int.Parse(Console.ReadLine());
            int quantity = 0;
            int litres = 0;

            for (int i = 0; i < lines; i++)
            {
                litres = int.Parse(Console.ReadLine());
                if (litres <= capacity)
                {
                    capacity = capacity - litres;
                    quantity = quantity + litres;
                }

                else if (true)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
               
            }
                Console.WriteLine(quantity);
        }
    }
}
