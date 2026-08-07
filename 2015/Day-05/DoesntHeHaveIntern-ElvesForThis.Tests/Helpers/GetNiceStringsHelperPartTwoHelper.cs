using DoesntHeHaveIntern_ElvesForThis.Helpers;

namespace DoesntHeHaveIntern_ElvesForThis.Tests.Helpers
{
    public class GetNiceStringsHelperPartTwoHelper
    {
        [Theory]
        [MemberData(nameof(MemberData.PartTwoStringData.TestData), MemberType = typeof(MemberData.PartTwoStringData))]
        public async Task GetNiceStringsPartTwo_ReturnsExpectedResults(List<string> input, List<string> expected)
        {
            // Arrange
            var sut = new GetNiceStringsHelperPartTwo();
            // Act
            var result = await sut.GetNiceStrings(input);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
