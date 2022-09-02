using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordInput = Console.ReadLine();
            int vowelsCount = GetVowelsCount(wordInput);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string word)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'y', 'u' };
            int vowelsCount = 0;

            foreach (char character in word.ToLower())
            {
                if (vowels.Contains(character))
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
