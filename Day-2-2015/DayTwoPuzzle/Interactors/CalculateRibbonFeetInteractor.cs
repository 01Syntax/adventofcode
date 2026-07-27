using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interactors
{
    public class CalculateRibbonFeetInteractor : ICalculateRibbonFeetInteractor
    {
        public int Handle(IEnumerable<Dimension> dimensions)
        {
            return dimensions.Sum(x =>
            {
                var side1 = x.Length;
                var side2 = x.Width;
                var side3 = x.Height;
                var ribbon = 2 * side1 + 2 * side2;
                var bow = side1 * side2 * side3;
                return ribbon + bow;
            });
        }
    }
}
