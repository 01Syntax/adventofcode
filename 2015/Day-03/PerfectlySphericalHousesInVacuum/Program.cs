using Microsoft.Extensions.DependencyInjection;
using PerfectlySphericalHousesInVacuum.Interactors;
using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Mappers;

namespace PerfectlySphericalHousesInVacuum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<App>();
            services.AddTransient<IFileManager, FileManager.FileManager>();
            services.AddTransient<IGetTotalHouseInteractor, GetTotalHouseInteractor>();
            services.AddTransient<IDirectionMapper, DirectionMapper>();

            var serviceProvider = services.BuildServiceProvider();
            var filePath = Path.Combine("DataSource", "directions.txt");
            serviceProvider.GetRequiredService<App>().Run(filePath);
        }
    }
}