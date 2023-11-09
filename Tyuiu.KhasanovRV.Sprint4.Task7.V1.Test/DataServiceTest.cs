using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint4.Task7.V1.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string str = "135792468";
            int wait = 4;

            var res = ds.Calculate(3, 3, str);
            Assert.AreEqual(wait, res);
        }
    }
}
