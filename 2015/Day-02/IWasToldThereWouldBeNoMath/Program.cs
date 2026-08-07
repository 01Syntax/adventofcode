using AoC.Shared;
using IWasToldThereWouldBeNoMath.Interactors;
using IWasToldThereWouldBeNoMath.Parsers;
using Microsoft.Extensions.DependencyInjection;

namespace IWasToldThereWouldBeNoMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<App>();
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IDimensionParser, DimensionParser>();
            services.AddTransient<ICalculateSurfaceAreaInteractor, CalculateSurfaceAreaInteractor>();
            services.AddTransient<ICalculateRibbonFeetInteractor, CalculateRibbonFeetInteractor>();

            var serviceProvider = services.BuildServiceProvider();
            var filePath = Path.Combine("DataSource", "dimensions.txt");
            serviceProvider.GetRequiredService<App>().Run(filePath);
        }
    }
}
