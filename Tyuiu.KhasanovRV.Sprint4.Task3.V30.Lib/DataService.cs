using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhasanovRV.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[2, i] > max)
                    max = array[2, i];
            }
            return max;
        }
    }
}
