using PerfectlySphericalHousesInVacuum.Interfaces;

namespace PerfectlySphericalHousesInVacuum
{
    public class App(IFileManager fileManager, IGetTotalHouseInteractor getTotalHouseInteractor, IPartTwoGetTotalHouseInteractor partTwoGetTotalHouseInteractor)
    {
        public void Run(string filePath)
        {
            var directions = fileManager.ReadFile(filePath);
            var totalDeliveries = getTotalHouseInteractor.Handle(directions);
            var robotAndSantaDeliveries = partTwoGetTotalHouseInteractor.Handle(directions);
            Console.WriteLine($"Total houses that received at least one delivery: {totalDeliveries}");
            Console.WriteLine($"Houses visited by both Santa and the robot: {robotAndSantaDeliveries}");
        }
    }
}