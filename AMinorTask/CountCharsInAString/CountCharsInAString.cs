using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();

            string[] text = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();

            foreach (var item in text)
            {
                foreach (var ch in item)
                {
                        if (!occurences.ContainsKey(ch))
                        {
                            occurences[ch] = 0;
                        }
                        occurences[ch] += 1;                       
                }
            }

            foreach (var item in occurences)
            {
                char character = item.Key;
                int repeats = item.Value;

                Console.WriteLine($"{character} -> {repeats}");
            }            
        }
    }
}
