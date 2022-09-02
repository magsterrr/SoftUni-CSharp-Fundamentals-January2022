using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] passengersInEachWagon = new int[numberOfWagons];
            int sumOfPassengers = 0;

            for (int i = 0; i < numberOfWagons; i++)
            {
                passengersInEachWagon[i] = int.Parse(Console.ReadLine());
                sumOfPassengers += passengersInEachWagon[i];
            }

            Console.WriteLine(String.Join(" ", passengersInEachWagon));
            Console.WriteLine(sumOfPassengers);
        }
    }
}
