using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Parsers
{
    public interface IDimensionParser
    {
        IEnumerable<Dimension> Parse(string content);
    }
}
