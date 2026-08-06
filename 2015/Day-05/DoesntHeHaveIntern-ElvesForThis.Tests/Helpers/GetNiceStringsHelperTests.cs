using DoesntHeHaveIntern_ElvesForThis.Helpers;

namespace DoesntHeHaveIntern_ElvesForThis.Tests.Helpers
{
    public class GetNiceStringsHelperTests
    {
        [Theory]
        [MemberData(nameof(MemberData.StringData.TestData), MemberType = typeof(MemberData.StringData))]
        public async Task GetNiceStrings_ReturnsExpectedResults(List<string> input, List<string> expected)
        {
            // Arrange
            var sut = new GetNiceStringsHelper();

            // Act
            var result = await sut.GetNiceStrings(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
