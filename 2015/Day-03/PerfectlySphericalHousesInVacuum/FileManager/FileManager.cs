namespace PerfectlySphericalHousesInVacuum.FileManager
{
    public class FileManager
    {
        public string ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            throw new FileNotFoundException("File not found", filePath);
        }
    }
}
