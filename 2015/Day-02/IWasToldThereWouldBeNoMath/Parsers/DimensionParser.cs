using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Parsers
{
    public class DimensionParser : IDimensionParser
    {
        public IEnumerable<Dimension> Parse(string content)
        {
            return content
                .Split(["\r\n", "\n"], StringSplitOptions.RemoveEmptyEntries)
                .Select((line, index) =>
                {
                    var parts = line.Split('x');
                    if (parts.Length != 3)
                        throw new FormatException($"Line {index + 1} is malformed: '{line}'. Expected format: 'LxWxH'.");

                    if (!int.TryParse(parts[0], out var length) ||
                        !int.TryParse(parts[1], out var width) ||
                        !int.TryParse(parts[2], out var height))
                        throw new FormatException($"Line {index + 1} contains non-integer values: '{line}'.");

                    return new Dimension(length, width, height);
                });
        }
    }
}
