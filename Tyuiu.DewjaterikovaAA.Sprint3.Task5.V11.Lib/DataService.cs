using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double series = 0;
            int j, k;
            for (j = startValue1; j <= stopValue1; j++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    series = series + (Math.Sin(k) + (x / 2));
                }
            }
            return Math.Round(series, 3);
        }
    }
}
