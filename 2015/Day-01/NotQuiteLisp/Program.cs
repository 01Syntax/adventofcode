using AoC.Shared;
using Microsoft.Extensions.DependencyInjection;
using NotQuiteLisp.Interactors;
using NotQuiteLisp.Interfaces;
using NotQuiteLisp.Managers;

namespace NotQuiteLisp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<App>();
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IGetFloorsInteractor, GetFloorsInteractor>();
            services.AddTransient<IGetPositionOfCharacterInteractor, GetPositionOfCharacterInteractor>();

            var serviceProvider = services.BuildServiceProvider();

            var app = serviceProvider.GetRequiredService<App>();
            app.Run();
        }
    }
}
