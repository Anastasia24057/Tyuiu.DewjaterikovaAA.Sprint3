using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task2.V29.Lib
{
    public class DataService : ISprint3Task2V29
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double series = 0;
            do
            {
                series = series + ((Math.Pow(value, startValue) + 0.25) * Math.Cos(startValue));
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(series, 3);
        }
    }
}
