using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Parsers
{
    public interface IDimensionParser
    {
        IEnumerable<Dimension> Parse(string content);
    }
}
