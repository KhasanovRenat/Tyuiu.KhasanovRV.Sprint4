using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint4.Task2.V14.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task2.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int[] array = new int[12];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = rnd.Next(1, 9);
            }
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length - 1;i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.Calculate(array);
            Console.WriteLine("Произведение = " + result);
            Console.ReadKey();
        }
    }
}
