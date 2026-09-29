using DoesntHeHaveIntern_ElvesForThis.Interactors;
using DoesntHeHaveIntern_ElvesForThis.Tests.MemberData;

namespace DoesntHeHaveIntern_ElvesForThis.Tests.Interactors
{
    public class GetTotalNiceStringsInteractorTests
    {
        [Theory]
        [MemberData(nameof(NiceStringsData.TestData), MemberType = typeof(NiceStringsData))]
        public async Task Handle_ReturnsCorrectCount(List<string> input, int expected)
        {
            // Arrange
            var sut = new GetTotalNiceStringsInteractor();

            // Act
            var result = await sut.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}