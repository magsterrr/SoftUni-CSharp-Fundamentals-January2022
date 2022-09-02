using System;
using System.Linq;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            int smallestNumber = GetSmallestOfThreeNumbers(number1, number2, number3);
            Console.WriteLine(smallestNumber);
        }
        static int GetSmallestOfThreeNumbers(int number1, int number2, int number3)
        {
            int smallestNumber = 0;

            if (number1 <= number2 && number1 <= number3)
            {
                smallestNumber = number1;
            }
            else if (number2 <= number1 && number2 <= number3)
            {
                smallestNumber = number2;
            }
            else if (number3 <= number2 && number3 <= number1)
            {
                smallestNumber = number3;
            }

            return smallestNumber;
        }
    }
}
