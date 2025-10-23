using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.DewjaterikovaAA.Sprint3.Task6.V26.Lib
{
    public class DataService : ISprint3Task6V26
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int count = 0;
            int x;
            for (x = 15;x <= 22; x++)
            {
                for (int d =1; d<=x;d++)
                {
                    if (x%d==0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
