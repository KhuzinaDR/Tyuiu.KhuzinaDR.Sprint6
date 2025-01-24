using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KhuzinaDR.Sprint6.Task4.V24.Lib
{
    public class DataService : ISprint6Task4V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] massive = new double[11];
            int count = 0;
            double result = 0;
            for (double x = startValue; x <= stopValue; x++)
            {
                result = x + 1.2 != 0 ? (Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2 * x : 0;
                massive[count] = Math.Round(result, 2);
                count++;
            }
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask4V24.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(result);
            }
            return massive;
        }
    }
}