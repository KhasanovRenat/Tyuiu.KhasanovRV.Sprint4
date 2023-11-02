using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KhasanovRV.Sprint4.Task0.V28.Lib;


namespace Tyuiu.KhasanovRV.Sprint4.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int wait = 9216;

            var rez = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, rez);
        }
    }
}
