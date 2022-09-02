using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = persons / capacity;
            int remainder = 0;
            remainder = persons % capacity;
            if (remainder > 0)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
