using Tyuiu.DewjaterikovaAA.Sprint3.Task7.V21.Lib;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();
            int startvalue = -5;
            int stopvalue = 5;

            int len = stopvalue - startvalue + 1;

            double[] valueMaitArray;
            valueMaitArray = new double[len];

            valueMaitArray[0] = 28.05;
            valueMaitArray[1] = 22.27;
            valueMaitArray[2] = 17.01;
            valueMaitArray[3] = 12.35;
            valueMaitArray[4] = 7.51;
            valueMaitArray[5] = 0.00;
            valueMaitArray[6] = 1.62;
            valueMaitArray[7] = -7.03;
            valueMaitArray[8] = -12.99;
            valueMaitArray[9] = -17.55;
            valueMaitArray[10] = -21.43;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startvalue, stopvalue);
            CollectionAssert.AreEqual(valueMaitArray, res);
            

        }
    }
}
