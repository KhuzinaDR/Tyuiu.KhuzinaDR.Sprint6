using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhuzinaDR.Sprint6.Task1.V7.Lib
{
    public class DataService : ISprint6Task1V7
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((2 * x - 3) / (Math.Cos(x) + x) + 5)), 2);
                valueArray[count] = y;
                count++;

            }
            return valueArray;
        }
    }
}