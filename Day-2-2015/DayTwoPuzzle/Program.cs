using DayTwoPuzzle.Converters;
using DayTwoPuzzle.Helpers;
using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace DayTwoPuzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();

            service.AddTransient<App>();
            service.AddTransient<IFileManager, FileManager>();
            service.AddTransient<IArraySorter, ArraySorter>();
            service.AddTransient<IStringToArrayConverter, StringToArrayConverter>();
            service.AddTransient<ICalculateSurfaceAreaInteractor, CalculateSurfaceAreaInteractor>();
            service.AddTransient<ICalculateAreaInteractor, CalculateAreaInteractor>();

            var serviceProvider = service.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            app.Run();
        }
    }
}
