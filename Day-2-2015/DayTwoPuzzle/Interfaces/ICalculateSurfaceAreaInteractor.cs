using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interfaces
{
    public interface ICalculateSurfaceAreaInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
