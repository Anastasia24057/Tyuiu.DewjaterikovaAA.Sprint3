using Tyuiu.DewjaterikovaAA.Sprint3.Task3.V4.Lib;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void DeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char chr = 'j';
            string res = ds.DeleteCharInString(str, chr);
            string wait = "plk  dw cv kl";
            Assert.AreEqual(wait, res);

        }
    }
}
