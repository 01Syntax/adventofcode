using DayTwoPuzzle.Interfaces;
using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Parsers
{
    public class DimensionParser : IDimensionParser
    {
        public IEnumerable<Dimension> Parse(string content)
        {
            return content
                .Split(["\r\n", "\n"], StringSplitOptions.RemoveEmptyEntries)
                .Select(line =>
                {
                    var parts = line.Split('x');
                    return new Dimension(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
                });
        }
    }
}
