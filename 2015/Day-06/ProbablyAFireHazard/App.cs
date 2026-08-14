using AoC.Shared;
using ProbablyAFireHazard.Logic.Interfaces;

namespace ProbablyAFireHazard
{
    public class App(IFileReader fileReader, IGetLightsOnLogic getLightsOnLogic, IInstructionMapper instructionMapper, IConvertTo2DArr convertTo2DArr)
    {
        public void Run(string filePath)
        {
            var lines = fileReader.ReadAsLines(filePath);
            var lightGrid = convertTo2DArr.Convert(lines);
            var instructions = instructionMapper.Map(lightGrid);
            var lightsOn = getLightsOnLogic.Handle(instructions);
            Console.WriteLine($"Lights on: {lightsOn}");
        }
    }
}
