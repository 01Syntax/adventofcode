using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Helpers
{
    public class App(ICalculateSurfaceAreaInteractor calculateSurfaceAreaInteractor, ICalculateAreaInteractor calculateAreaInteractor, IStringToArrayConverter stringToArrayConverter, IArraySorter arraySorter)
    {
        public void Run()
        {
            var filePath = Path.Combine("DataSource", "dimensions.txt");
            var dimensions = stringToArrayConverter.ConvertStringTo2DArr(filePath);
            var sortedArr = arraySorter.Sort2DArray(dimensions);
            var surfaceArea = calculateSurfaceAreaInteractor.Handle(dimensions);
            var area = calculateAreaInteractor.Handle(sortedArr);
            Console.WriteLine($"The total surface area is: {surfaceArea + area}");
        }
    }
}
