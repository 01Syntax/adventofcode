using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Interactors
{
    public interface ICalculateRibbonFeetInteractor
    {
        int Handle(IEnumerable<Dimension> dimensions);
    }
}
