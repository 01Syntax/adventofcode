using AoC.Shared;
using DoesntHeHaveIntern_ElvesForThis.Helpers;
using DoesntHeHaveIntern_ElvesForThis.interactors;
using DoesntHeHaveIntern_ElvesForThis.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DoesntHeHaveIntern_ElvesForThis
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IGetNiceStringsHelper, GetNiceStringsHelper>();
            services.AddTransient<IGetTotalNiceStringsInteractor, GetTotalNiceStringsInteractor>();
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IGetTotalNiceStringsPartTwoInteractor, GetTotalNiceStringsPartTwoInteractor>();
            services.AddTransient<IGetNiceStringsHelperPartTwo, GetNiceStringsHelperPartTwo>();
            services.AddTransient<App>();

            var serviceProvider = services.BuildServiceProvider();
            var app = serviceProvider.GetRequiredService<App>();
            await app.Run();
        }
    }
}
