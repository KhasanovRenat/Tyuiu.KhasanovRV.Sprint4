using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint4.Task1.V12.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 4, 8, 6, 4, 9, 5, 8, 7, 8, 4, 7, 6, 8 };

            int wait = 2205;

            var result = ds.Calculate(array);
            Assert.AreEqual(wait, result);
        }
    }
}
