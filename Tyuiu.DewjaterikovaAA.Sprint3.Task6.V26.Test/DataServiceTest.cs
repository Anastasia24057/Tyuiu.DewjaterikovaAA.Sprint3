using Tyuiu.DewjaterikovaAA.Sprint3.Task6.V26.Lib;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task6.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 33;
            Assert.AreEqual(wait, res);
        }
    }
}
