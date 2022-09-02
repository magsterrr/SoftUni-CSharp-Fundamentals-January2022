using System;

namespace ExericeDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long sum = (long)firstNum + (long)secondNum;
            long divide = sum / (long)thirdNum;
            decimal finalResult = (decimal)divide * (decimal)fourthNum;

            Console.WriteLine(finalResult);
        }
    }
}
