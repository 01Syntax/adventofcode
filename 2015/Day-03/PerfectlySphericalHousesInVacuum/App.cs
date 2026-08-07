using AoC.Shared;
using PerfectlySphericalHousesInVacuum.Interfaces;

namespace PerfectlySphericalHousesInVacuum
{
    public class App(IFileReader fileReader, IDirectionMapper directionMapper, IGetTotalHouseInteractor getTotalHouseInteractor, IPartTwoGetTotalHouseInteractor partTwoGetTotalHouseInteractor)
    {
        public void Run(string filePath)
        {
            var directions = fileReader.ReadAsString(filePath).Select(directionMapper.MapToDirection).ToList();
            var totalDeliveries = getTotalHouseInteractor.Handle(directions);
            var robotAndSantaDeliveries = partTwoGetTotalHouseInteractor.Handle(directions);
            Console.WriteLine($"Total houses that received at least one delivery: {totalDeliveries}");
            Console.WriteLine($"Houses visited by both Santa and the robot: {robotAndSantaDeliveries}");
        }
    }
}
