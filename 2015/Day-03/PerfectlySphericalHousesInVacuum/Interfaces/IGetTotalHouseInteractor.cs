using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interfaces;

public interface IGetTotalHouseInteractor
{
    int Handle(List<Direction> directions);
}