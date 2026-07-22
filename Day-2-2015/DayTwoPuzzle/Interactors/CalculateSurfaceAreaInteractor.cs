using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interactors
{
    public class CalculateSurfaceAreaInteractor : ICalculateSurfaceAreaInteractor
    {
        public int Handle(IEnumerable<Dimension> dimensions)
        {
            return dimensions.Sum(d =>
            {
                var side1 = d.Length * d.Width;
                var side2 = d.Width * d.Height;
                var side3 = d.Height * d.Length;
                var slack = Math.Min(side1, Math.Min(side2, side3));
                return 2 * side1 + 2 * side2 + 2 * side3 + slack;
            });
        }
    }
}
