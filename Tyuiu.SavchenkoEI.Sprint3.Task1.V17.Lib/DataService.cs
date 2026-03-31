using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SavchenkoEI.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int i = 0;
            double res=1;
            while (i<stopValue) 
            {
                res*=Math.Pow(2/(Math.Cos(value)),i+1);
                i++;
            }
            return Math.Round(res, 3);
        }
    }
}
