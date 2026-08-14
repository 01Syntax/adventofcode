namespace AoC.Shared.Helpers
{
    public class ConvertTo2DArr
    {
        public string[,] Convert(List<string> lines)
        {
            var arr = new string[lines.Count, 1];
            for (int i = 0; i < lines.Count; i++)
            {
                arr[i, 0] = lines[i];
            }
            return arr;
        }
    }
}
