﻿using Tyuiu.DewjaterikovaAA.Sprint3.Task4.V19.Lib;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = 9.432;
            Assert.AreEqual(wait, res);
        }
    }
}
