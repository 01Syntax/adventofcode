using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Interfaces
{
    public interface IDimensionParser
    {
        IEnumerable<Dimension> Parse(string content);
    }
}
