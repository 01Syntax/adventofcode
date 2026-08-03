using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interfaces
{
    public interface IDirectionMapper
    {
        Direction MapToDirection(char direction);
    }
}
