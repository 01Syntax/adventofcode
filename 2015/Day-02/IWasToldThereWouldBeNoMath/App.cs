using AoC.Shared;
using IWasToldThereWouldBeNoMath.Interactors;
using IWasToldThereWouldBeNoMath.Parsers;

namespace IWasToldThereWouldBeNoMath
{
    public class App(IFileReader fileReader, IDimensionParser dimensionParser, ICalculateSurfaceAreaInteractor calculateSurfaceAreaInteractor, ICalculateRibbonFeetInteractor calculateRibbonFeetInteractor)
    {
        public void Run(string filePath)
        {
            var content = fileReader.ReadAsString(filePath);
            var dimensions = dimensionParser.Parse(content);
            var totalWrappingPaper = calculateSurfaceAreaInteractor.Handle(dimensions);
            var totalRibbon = calculateRibbonFeetInteractor.Handle(dimensions);
            Console.WriteLine($"The total wrapping paper needed is: {totalWrappingPaper}");
            Console.WriteLine($"The total ribbon needed is: {totalRibbon}");
        }
    }
}
