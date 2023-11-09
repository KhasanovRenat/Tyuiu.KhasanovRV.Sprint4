using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KhasanovRV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task4.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Хасанов Р. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Хасанов Ренат Владиславович | СМАРТб-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 4 до 7. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] matrix = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива:");
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nИсходный массив:");
            for (int i = 0;i < 5; i++)
            {
                for (int j = 0;j < 5; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var result = ds.Calculate(matrix);
            Console.WriteLine("Новый массив:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{result[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
