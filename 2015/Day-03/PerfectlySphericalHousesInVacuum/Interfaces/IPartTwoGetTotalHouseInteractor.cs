using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interfaces
{
    public interface IPartTwoGetTotalHouseInteractor
    {
        int Handle(List<Direction> directions);
    }
}
