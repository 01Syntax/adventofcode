using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Managers
{
    public class FileManager : IFileManager
    {
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}