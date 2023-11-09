using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint4.Task4.V18.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 4, 7, 4, 5, 4 },
                                            { 4, 4, 5, 6, 7 },
                                            { 7, 5, 6, 6, 6 },
                                            { 6, 7, 6, 6, 4 },
                                            { 5, 6, 6, 6, 5 } };

            int[,] wait = new int[5, 5] {   { 4, 0, 4, 0, 4 },
                                            { 4, 4, 0, 6, 0 },
                                            { 0, 0, 6, 6, 6 },
                                            { 6, 0, 6, 6, 4 },
                                            { 0, 6, 6, 6, 0 } };

            var rez = ds.Calculate(matrix);

            CollectionAssert.AreEqual(wait, rez);
        }
    }
}
