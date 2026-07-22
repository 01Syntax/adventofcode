using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Managers
{
    public class FileManager : IFileManager
    {
        public string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            else
            {
                throw new FileNotFoundException($"File not found at path: {filePath}");
            }
        }
    }
}