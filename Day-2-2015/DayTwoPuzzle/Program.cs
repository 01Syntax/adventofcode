using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Managers;
using DayTwoPuzzle.Parsers;
using Microsoft.Extensions.DependencyInjection;

namespace DayTwoPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<App>();
            services.AddTransient<IFileManager, FileManager>();
            services.AddTransient<IDimensionParser, DimensionParser>();
            services.AddTransient<ICalculateSurfaceAreaInteractor, CalculateSurfaceAreaInteractor>();
            services.AddTransient<ICalculateRibbonFeetInteractor, CalculateRibbonFeetInteractor>();

            var serviceProvider = services.BuildServiceProvider();
            var filePath = Path.Combine("DataSource", "dimensions.txt");
            serviceProvider.GetRequiredService<App>().Run(filePath);
        }
    }
}
