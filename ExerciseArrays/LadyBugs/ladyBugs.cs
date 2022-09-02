using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            // казваме колко е голям масива
            int fieldSize = int.Parse(Console.ReadLine());
            // въвеждаме индексите където има калинки (примерно на индекс 0 и индекс 1)
            int[] ladyBugsIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //създаваме масив с въведената горе големина
            int[] field = new int[fieldSize];

            //цикъла се върти колкото индекси(калинки) има в масива
            for (int index = 0;index < fieldSize; index++)
            {
                if (ladyBugsIndexes.Contains(index)) // ако този индекс е въведен горе,
                    //значи тук ще се добави 1 към този индекс(тоест, казваме че има калинка там)
                {
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end") //докато не кажем енд ще се върти
            {
                string[] commandArg = command //тук казваме накъде да лети калинката и колко
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int initialIndex = int.Parse(commandArg[0]); //откъде лети калинката
                string direction = commandArg[1]; // накъде лети калинката
                int flyLenght = int.Parse(commandArg[2]); // колко лети калинката (индекси)

                if (initialIndex < 0 || initialIndex >= field.Length)
                {
                    continue; //невалидно и защото подадения индекс(място) е извън масива
                }

                if (field[initialIndex] == 0)
                {
                    continue; //невалидно е защото тук калинка няма
                }

                field[initialIndex] = 0;

                int nextIndex = initialIndex;//индекса на който ще отиде калинката (кацне)
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLenght; //към където е била калинката(индекса) добавяме броя индекси които ще лети(дясно)
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLenght;//намаляме индекса където е била за да отиде наляво
                    }

                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;//калинката излиза извън масива
                    }

                    if (field[nextIndex] == 0)
                    {
                        break; // калинката няма да лети изобщо
                    }
                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1; //калинката каза тук(казваме й на кой индекс
                }
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}
