using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Этап А");
            Random random = new Random();
            int[,] Table = new int[3, 8];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Table[i, j] = random.Next(-100, 100);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{Table[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();


            Console.WriteLine("Этап В");
            int Sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Sum += Table[i, j];
                }
            }
            Console.WriteLine(Sum/24);
            Console.ReadLine();


            Console.WriteLine("Этап С");
            int randomBiggerSum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (Table[i, j] > 0)
                    {
                        randomBiggerSum += 1;
                    }
                }
            }
            Console.WriteLine(randomBiggerSum);
            Console.ReadLine();


            Console.WriteLine("Этап D");
            Console.WriteLine("Введите число:");
            string userInputStr = Console.ReadLine();

            int userInput;
            if (!int.TryParse(userInputStr, out userInput))
            {
                Console.WriteLine("Ошибка: Введено некорректное число");
            }
            else
            {
                bool found = false;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (Table[i, j] == userInput)
                        {
                            Console.WriteLine("Элемент " + Table[i, j] + " находится в строке " + i + " в массиве под индексом " + j);
                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Число " + userInput + " не найдено в массиве");
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
