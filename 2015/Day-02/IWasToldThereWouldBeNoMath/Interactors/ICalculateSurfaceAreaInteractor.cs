using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Interactors
{
    public interface ICalculateSurfaceAreaInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
