using DayTwoPuzzle.Interfaces;

namespace DayTwoPuzzle.Interactors
{
    public class CalculateSurfaceAreaInteractor : ICalculateSurfaceAreaInteractor
    {
        public int Handle(int[,] dimensions)
        {
            var surfaceArea = 0;
            var rows = dimensions.GetLength(0);

            for (var i = 0; i < rows; i++)
            {
                var l = dimensions[i, 0];
                var w = dimensions[i, 1];
                var h = dimensions[i, 2];

                var side1 = l * w;
                var side2 = w * h;
                var side3 = h * l;

                surfaceArea += 2 * side1 + 2 * side2 + 2 * side3;
            }

            return surfaceArea;

        }
    }
}
