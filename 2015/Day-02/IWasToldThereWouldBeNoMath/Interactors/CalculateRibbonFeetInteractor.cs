using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Interactors
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
                var sides = new[] { side1, side2, side3 };
                Array.Sort(sides);
                var ribbon = 2 * sides[0] + 2 * sides[1];
                var bow = sides[0] * sides[1] * sides[2];
                return ribbon + bow;
            });
        }
    }
}
