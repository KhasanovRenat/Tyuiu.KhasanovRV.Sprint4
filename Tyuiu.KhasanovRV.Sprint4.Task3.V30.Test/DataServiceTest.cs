using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint4.Task3.V30.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new[,] { { 2, 4, 3, 5, 1 }, 
                                    { 6, 6, 1, 2, 6 }, 
                                    { 3, 3, 2, 1, 5 }, 
                                    { 6, 4, 1, 3, 3 }, 
                                    { 5, 1, 1, 6, 4 } };
            int wait = 5;

            var res = ds.Calculate(array);

            Assert.AreEqual(wait, res);
        }
    }
}
