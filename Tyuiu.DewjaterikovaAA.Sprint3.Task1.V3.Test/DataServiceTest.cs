using Tyuiu.DewjaterikovaAA.Sprint3.Task1.V3.Lib;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 24589.408;
            Assert.AreEqual(wait, res);
        }
    }
}
