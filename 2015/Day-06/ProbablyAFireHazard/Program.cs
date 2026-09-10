using AoC.Shared;
using Microsoft.Extensions.DependencyInjection;
using ProbablyAFireHazard.Logic.Helpers;
using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Logic;
using ProbablyAFireHazard.Logic.Mappers;

namespace ProbablyAFireHazard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddTransient<IConvertTo2DArr, ConvertTo2DArr>();
            services.AddTransient<IGetLightsOnLogic, GetLightsOnLogic>();
            services.AddTransient<IInstructionMapper, InstructionMapper>();
            services.AddTransient<IFileReader, FileReader>();
            services.AddTransient<IActionMapper, ActionMapper>();
            services.AddTransient<App>();

            var serviceProvider = services.BuildServiceProvider();
            var filePath = Path.Combine(AppContext.BaseDirectory, "DataSource", "instructions.txt");
            serviceProvider.GetRequiredService<App>().Run(filePath);
        }
    }
}
