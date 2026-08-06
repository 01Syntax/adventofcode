namespace IWasToldThereWouldBeNoMath.Managers
{
    public class FileManager : IFileManager
    {
        public List<string> ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"File not found at path: {filePath}");

            return File.ReadAllLines(filePath).ToList();
        }
    }
}