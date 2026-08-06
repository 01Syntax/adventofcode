namespace IWasToldThereWouldBeNoMath.Managers
{
    public class FileManager : IFileManager
    {
        public async Task<List<string>> ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found at path: {filePath}");

            var lines = await File.ReadAllLinesAsync(filePath);

            return lines.ToList();
        }
    }
}