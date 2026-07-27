using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interactors
{
    public interface ICalculateSurfaceAreaInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
