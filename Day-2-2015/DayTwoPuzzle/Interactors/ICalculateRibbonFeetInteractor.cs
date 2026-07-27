using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interactors
{
    public interface ICalculateRibbonFeetInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
