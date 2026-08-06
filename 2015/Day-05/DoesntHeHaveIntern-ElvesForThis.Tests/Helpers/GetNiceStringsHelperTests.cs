namespace DoesntHeHaveIntern_ElvesForThis.Tests.Helpers
{
    public class GetNiceStringsHelperTests
    {
        [Theory]
        [MemberData(nameof(MemberData.StringData.TestData), MemberType = typeof(MemberData.StringData))]
        public void GetNiceStrings_ReturnsExpectedResults(List<string> input, List<string> expected)
        {
            // Arrange
            var sut = new GetNiceStringsHelper();

            // Act
            var result = sut.GetNiceStrings(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
