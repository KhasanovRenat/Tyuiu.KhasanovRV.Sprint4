using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint4.Task3.V30.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 1 до 6. Найдите максимальный     *");
            Console.WriteLine("* элемент в третьей строке массива.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] array = new[,] { { 2, 4, 3, 5, 1 },
                                    { 6, 6, 1, 2, 6 },
                                    { 3, 3, 2, 1, 5 },
                                    { 6, 4, 1, 3, 3 },
                                    { 5, 1, 1, 6, 4 } };
            Console.WriteLine("Массив:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[0,i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[1,i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[2,i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[3,i] + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.Write(array[4,i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.Calculate(array);
            Console.WriteLine("Максимальый элемент в третьей строке " + result);
            Console.ReadKey();
        }
    }
}
