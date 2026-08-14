using AoC.Shared;
using ProbablyAFireHazard.Logic.Interfaces;

namespace ProbablyAFireHazard
{
    public class App(IFileReader fileReader, IGetLightsOnLogic getLightsOnLogic, IInstructionMapper instructionMapper, IConvertTo2DArr convertTo2DArr)
    {
        public void Run(string filePath)
        {
            var instructions = fileReader.ReadAsLines(filePath);
            var lightGrid = convertTo2DArr.Convert(instructions);
            var mappedInstructions = instructionMapper.Map(instructions);
            var lightsOn = getLightsOnLogic.GetLightsOn(mappedInstructions);
            Console.WriteLine($"Lights on: {lightsOn}");
        }
    }
}
