using IWasToldThereWouldBeNoMath.Models;
using IWasToldThereWouldBeNoMath.Parsers;
using IWasToldThereWouldBeNoMath.Tests.MemberData;

namespace IWasToldThereWouldBeNoMath.Tests.Parsers
{
    public class DimensionParserTests
    {
        [Theory]
        [MemberData(nameof(MemberDataHelper.TestData), MemberType = typeof(MemberDataHelper))]
        public void Parse_ReturnsCorrectDimensions(string content, IEnumerable<Dimension> expected)
        {
            var sut = new DimensionParser();
            var result = sut.Parse(content);
            Assert.Equal(expected, result);
        }
    }
}
