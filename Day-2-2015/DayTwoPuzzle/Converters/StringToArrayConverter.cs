using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Converters
{
    public class StringToArrayConverter(IFileManager fileManager)
    {
        public int[,] ConvertStringTo2DArr(string filePath)
        {
            var fetchedData = fileManager.ReadFile(filePath);
            var lines = fetchedData.Split(
                ["\r\n", "\n"],
                StringSplitOptions.RemoveEmptyEntries);
            var rows = lines.Length;
            var cols = lines[0].Split('x').Length;
            var array2D = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var values = lines[i].Split('x');

                for (int j = 0; j < cols; j++)
                {
                    array2D[i, j] = int.Parse(values[j]);
                }
            }

            return array2D;
        }
    }
}
