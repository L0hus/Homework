using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.ReadLine();
            int[] randNum = new int[10];
            int RandNumLen = randNum.Length;
            int Sum = 0;

            Console.WriteLine("Этап А");
            for (int i = 0; i < 10; i++)
            {
                int randomNumber = random.Next(-100, 100);
                randNum[i] = randomNumber;
                Sum += randomNumber;
                Console.WriteLine(randomNumber);
            }
            Console.ReadLine();


            Console.WriteLine("Этап В");
            for (int i = 0; i < RandNumLen ; i++)
            {
                Sum += randNum[i];
            }
            int SrSum = Sum / 10;
            Console.WriteLine(string.Join("Среднее арифметическое - ", SrSum));
            Console.ReadLine();


            Console.WriteLine("Этап С");
            int[] RandNumBigger = new int[10];
            int RandNumSum = 0;
            for (int i = 0; i < RandNumLen; i++)
            {
                if (randNum[i] > SrSum)
                {
                    RandNumSum += 1;
                    RandNumBigger[i] = randNum[i];
                }

                else
                {
                    continue;
                }
            }
            int[] RandNumSumList = new int[RandNumSum];
            int positiveCount = 0;
            for (int i = 0; i < RandNumLen; i++)
            {
                if (RandNumBigger[i] != 0)
                {
                    RandNumSumList[positiveCount] = RandNumBigger[i];
                    positiveCount++;
                }
                
                else
                {
                    continue;
                }
            }
            Array.Resize(ref RandNumSumList, positiveCount);
            Console.WriteLine(string.Join(", ", RandNumSumList));
            Console.ReadLine() ;


            Console.WriteLine("Этап D");
            int[] RandNumSumListSort = new int[RandNumSumList.Length];
            Array.Copy(RandNumSumList, RandNumSumListSort, RandNumSumList.Length);
            Array.Sort(RandNumSumListSort);
            Console.WriteLine(string.Join(", ", RandNumSumListSort));
            Console.ReadLine() ;


            Console.WriteLine("Этап Е");
            int SumMed = 0;
            for (int i = 0; i < RandNumSumListSort.Length; i++)
            {
                if (RandNumSumListSort.Length % 2 > 0)
                {

                    if (RandNumSumListSort.Length == 1)
                    {
                        Console.WriteLine(string.Join(", ", RandNumSumListSort[0]));
                        break;
                    }

                    if (RandNumSumListSort.Length == 3)
                    {
                        Console.WriteLine(string.Join(", ", RandNumSumListSort[1]));
                        break;
                    }

                    if (RandNumSumListSort.Length == 5)
                    {
                        Console.WriteLine(string.Join(", ", RandNumSumListSort[2]));
                        break;
                    }

                    if (RandNumSumListSort.Length == 7)
                    {
                        Console.WriteLine(string.Join(", ", RandNumSumListSort[3]));
                        break;
                    }

                    if (RandNumSumListSort.Length == 9)
                    {
                        Console.WriteLine(string.Join(", ", RandNumSumListSort[4]));
                        break;
                    }

                }

                else
                {

                    if (RandNumSumListSort.Length == 2)
                    {
                        SumMed += RandNumSumListSort[0];
                        SumMed += RandNumSumListSort[1];
                        Console.WriteLine(string.Join(", ", SumMed/2));
                        break;
                    }

                    if (RandNumSumListSort.Length == 4)
                    {
                        SumMed += RandNumSumListSort[1];
                        SumMed += RandNumSumListSort[2];
                        Console.WriteLine(string.Join(", ", SumMed / 2));
                        break;
                    }

                    if (RandNumSumListSort.Length == 6)
                    {
                        SumMed += RandNumSumListSort[2];
                        SumMed += RandNumSumListSort[3];
                        Console.WriteLine(string.Join(", ", SumMed / 2));
                        break;
                    }

                    if (RandNumSumListSort.Length == 8)
                    {
                        SumMed += RandNumSumListSort[3];
                        SumMed += RandNumSumListSort[4];
                        Console.WriteLine(string.Join(", ", SumMed / 2));
                        break;
                    }

                    if (RandNumSumListSort.Length == 10)
                    {
                        SumMed += RandNumSumListSort[4];
                        SumMed += RandNumSumListSort[5];
                        Console.WriteLine(string.Join(", ", SumMed / 2));
                        break;
                    }

                }
            }
            Console.ReadLine();


            Console.WriteLine("Этап F");
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();

            int UserNumber;
            if (!int.TryParse(input, out UserNumber))
            {
                Console.WriteLine("Ошибка: Введено некорректное число");
            }
            {
                bool found = false;
                for (int i = 0; i < randNum.Length; i++)
                {
                    if (randNum[i] == UserNumber)
                    {
                        Console.WriteLine("Элемент " + randNum[i] + " находится в массиве под индексом " + i);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Число " + UserNumber + " не найдено в массиве");
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
