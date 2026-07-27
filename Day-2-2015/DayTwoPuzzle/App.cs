using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Managers;
using DayTwoPuzzle.Parsers;

namespace DayTwoPuzzle
{
    public class App(IFileManager fileManager, IDimensionParser dimensionParser, ICalculateSurfaceAreaInteractor calculateSurfaceAreaInteractor, ICalculateRibbonFeetInteractor calculateRibbonFeetInteractor)
    {
        public void Run(string filePath)
        {
            var content = fileManager.ReadFile(filePath);
            var dimensions = dimensionParser.Parse(content);
            var totalWrappingPaper = calculateSurfaceAreaInteractor.Handle(dimensions);
            var totalRibbon = calculateRibbonFeetInteractor.Handle(dimensions);
            Console.WriteLine($"The total wrapping paper needed is: {totalWrappingPaper}");
            Console.WriteLine($"The total ribbon needed is: {totalRibbon}");
        }
    }
}
