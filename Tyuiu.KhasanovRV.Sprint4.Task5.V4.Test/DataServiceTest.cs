using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint4.Task5.V4.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 0, -2, -4, 5, -4 },
                                            { 4, -4, 5, -6, 7 },
                                            { -7, -5, 6, 6, -6 },
                                            { -6, -7, 6, 6, -4 },
                                            { -5, -6, -6, -6, -5 } };

            int wait = 8;

            var rez = ds.Calculate(matrix);

            Assert.AreEqual(wait, rez);
        }
    }
}
