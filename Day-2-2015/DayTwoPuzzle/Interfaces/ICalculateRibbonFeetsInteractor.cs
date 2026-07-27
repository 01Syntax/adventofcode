using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interfaces
{
    public interface ICalculateRibbonFeetInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
