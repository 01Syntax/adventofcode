using Microsoft.Extensions.DependencyInjection;
using TheIdealStockingStuffer.Helpers;
using TheIdealStockingStuffer.Interactors;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IGenerateHashHelper, GenerateHashHelper>();
            services.AddTransient<IGetLowestNumberInteractor, GetLowestNumberInteractor>();
            services.AddTransient<IMdManager, MdManager>();
            services.AddTransient<App>();

            var serviceProvider = services.BuildServiceProvider();
            var secretKey = "iwrupvqb";
            serviceProvider.GetRequiredService<App>().Run(secretKey);
        }
    }
}
