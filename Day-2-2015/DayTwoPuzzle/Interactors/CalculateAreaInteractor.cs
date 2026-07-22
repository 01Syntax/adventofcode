using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Interactors
{
    public class CalculateAreaInteractor(IArraySorter arraySorter) : ICalculateAreaInteractor
    {
        public int Handle(int[,] dimensions)
        {
            var area = 0;
            var sortedDimensions = arraySorter.Sort2DArray(dimensions);
            var rows = dimensions.GetLength(0);

            for (var i = 0; i < rows; i++)
            {
                var l = sortedDimensions[i, 0];
                var h = sortedDimensions[i, 1];

                area += l * h;
            }

            return area;
        }
    }
}
