using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.FileManager
{
    public class FileManager(IDirectionMapper directionMapper) : IFileManager
    {
        public List<Direction> ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath).Select(directionMapper.MapToDirection).ToList();
            }
            throw new FileNotFoundException("File not found", filePath);
        }
    }
}