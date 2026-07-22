using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Interfaces;
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

            var serviceProvider = services.BuildServiceProvider();
            serviceProvider.GetRequiredService<App>().Run();
        }
    }
}
