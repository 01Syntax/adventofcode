using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Helpers
{
    public class ArraySorter : IArraySorter
    {
        public int[,] Sort2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                var row = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    row[j] = array[i, j];
                }

                Array.Sort(row);

                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = row[j];
                }
            }

            return array;
        }
    }
}