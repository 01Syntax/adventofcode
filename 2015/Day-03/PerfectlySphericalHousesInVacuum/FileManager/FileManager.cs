using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Mappers;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.FileManager
{
    public class FileManager : IFileManager
    {
        public List<Direction> ReadFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath).Select(c => new DirectionMapper().MapToDirection(c)).ToList();
            }
            throw new FileNotFoundException("File not found", filePath);
        }
    }
}
