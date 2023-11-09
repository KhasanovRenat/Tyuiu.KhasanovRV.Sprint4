using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhasanovRV.Sprint4.Task6.V6.Lib;

namespace Tyuiu.KhasanovRV.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string[] array = { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };

            string[] wait = { "Борис", "Ирина" };

            var rez = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, rez);
        }
    }
}
