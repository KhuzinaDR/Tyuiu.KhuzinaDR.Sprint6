using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhuzinaDR.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
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

                y = Math.Round(Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5)) + 2 * x, 2);



                valueArray[count] = y;
                count++;


            }
            return valueArray;
        }
    }
}