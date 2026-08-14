using ProbablyAFireHazard.Logic.Interfaces;

namespace ProbablyAFireHazard.Logic.Helpers
{
    public class ConvertTo2DArr : IConvertTo2DArr
    {
        public string[,] Convert(List<string> instructions)
        {
            var arr = new string[instructions.Count, 5];

            for (int i = 0; i < instructions.Count; i++)
            {
                var parts = instructions[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int startIndex = parts[0] == "turn" ? 1 : 0;

                arr[i, 0] = parts[startIndex];

                var startCoordinates = parts[startIndex + 1].Split(',');
                var endCoordinates = parts[startIndex + 3].Split(',');
                arr[i, 1] = startCoordinates[0];
                arr[i, 2] = startCoordinates[1];
                arr[i, 3] = endCoordinates[0];
                arr[i, 4] = endCoordinates[1];
            }
            return arr;
        }
    }
}
