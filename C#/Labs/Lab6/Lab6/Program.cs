using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;

            try
            {
                using (FileStream fs0 = new FileStream("квадраты.bin", FileMode.Create, FileAccess.Write))
                {
                    using (BinaryWriter writer = new BinaryWriter(fs0))
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            int square = i * i;
                            writer.Write(square);
                            Sum += 1;
                        }
                    }
                }
            Console.WriteLine("Числовая последовательность квадратов натуральных чисел от 1 до " + n + " была записана в файл.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            int[] ReadingFile = new int[n];

            try
            {
                using (FileStream fsR = new FileStream("квадраты.bin", FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fsR))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            ReadingFile[i] = reader.ReadInt32();
                        }
                    }
                }
            Console.WriteLine(string.Join(", ", ReadingFile));
            Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            int[] ReadingTextFile = new int[n];
            try
            {
                using (StreamWriter ftO = new StreamWriter("квадраты.txt"))
                {
                    for (int i = 0; i <= ReadingFile.Length - 1; i++)
                    {
                        ftO.WriteLine(Convert.ToString(ReadingFile[i]));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            try
            {
                Console.WriteLine("Числа в текстовом документе");
                using (StreamReader ftI = new StreamReader("квадраты.txt"))
                {
                    for (int i = 0; i <= ReadingFile.Length - 1; i++)
                    {
                        ReadingTextFile[i] = Convert.ToInt32(ftI.ReadLine());
                    }
                }
            Console.WriteLine(string.Join (", ", ReadingTextFile));
            Console.ReadLine();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            int TextSum = 0;
            for (int i = 0; i < ReadingTextFile.Length; i++)
            {
                TextSum += ReadingTextFile[i];
            }
            Console.WriteLine("Сумма всех чисел");
            Console.WriteLine(string.Join (", ", TextSum));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
