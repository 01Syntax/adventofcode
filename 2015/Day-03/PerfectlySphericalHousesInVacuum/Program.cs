using AoC.Shared;
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
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IGetTotalHouseInteractor, GetTotalHouseInteractor>();
            services.AddTransient<IDirectionMapper, DirectionMapper>();
            services.AddTransient<IPartTwoGetTotalHouseInteractor, PartTwoGetTotalHouseInteractor>();

            var serviceProvider = services.BuildServiceProvider();
            var filePath = Path.Combine("DataSource", "directions.txt");
            serviceProvider.GetRequiredService<App>().Run(filePath);
        }
    }
}
