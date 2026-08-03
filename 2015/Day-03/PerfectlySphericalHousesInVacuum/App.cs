using PerfectlySphericalHousesInVacuum.Interfaces;

namespace PerfectlySphericalHousesInVacuum
{
    public class App(IFileManager fileManager, IGetTotalHouseInteractor getTotalHouseInteractor)
    {
        public void Run(string filePath)
        {
            var directions = fileManager.ReadFile(filePath);
            var totalDeliveries = getTotalHouseInteractor.Handle(directions);
            Console.WriteLine($"Total houses that received at least one delivery: {totalDeliveries}");
        }
    }
}