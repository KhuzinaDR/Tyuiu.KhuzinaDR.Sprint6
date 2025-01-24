using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhuzinaDR.Sprint6.Task7.V24.Lib
{
    public class DataService : ISprint6Task7V24
    {
        public int[,] GetMatrix(string path)
        {
            int rows;
            int colums;
            string fileData = File.ReadAllText(path);

            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] aValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] lines_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    aValues[r, c] = Convert.ToInt32(lines_r[c]);
                }
            }
            int xRow = 1;

            for (int i = xRow; i <= xRow; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (aValues[i, j] % 2 == 0)
                    {
                        aValues[i, j] = 1;
                    }
                }
            }
            return aValues;

        }
    }
}