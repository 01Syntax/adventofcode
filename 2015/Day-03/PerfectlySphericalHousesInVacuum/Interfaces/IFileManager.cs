using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interfaces;

public interface IFileManager
{
    List<Direction> ReadFile(string filePath);
}