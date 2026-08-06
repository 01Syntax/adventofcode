using DoesntHeHaveIntern_ElvesForThis.interactors;
using DoesntHeHaveIntern_ElvesForThis.Tests.MemberData;

namespace DoesntHeHaveIntern_ElvesForThis.Tests.Interactors
{
    public class GetTotalNiceStringsInteractorTests
    {
        [Theory]
        [MemberData(nameof(NiceStringsData.TestData), MemberType = typeof(NiceStringsData))]
        public void Handle_ReturnsCorrectCount(List<string> input, int expected)
        {
            // Arrange
            var sut = new GetTotalNiceStringsInteractor();

            // Act
            var result = sut.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}