using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KhuzinaDR.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            int[] newcol = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                newcol[i] = matrix[i, columns - 1];
            }
            Array.Sort(newcol);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, columns - 1] = newcol[i];
            }
            return matrix;
        }
    }
}