using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interfaces;

public interface IGetTotalHouseInteractor
{
    int GetTotalDeliveries(List<Direction> directions);
}