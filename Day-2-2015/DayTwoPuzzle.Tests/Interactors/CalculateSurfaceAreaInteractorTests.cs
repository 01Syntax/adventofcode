using DayTwoPuzzle.Tests.MemberData;

namespace DayTwoPuzzle.Tests.Interactors
{
    public class CalculateSurfaceAreaInteractorTests
    {
        [Theory]
        [MemberData(nameof(DimensionsMemberData.TestData), MemberType = typeof(DimensionsMemberData))]
        public void Handle_ReturnsSurfaceArea(int[,] input, int expected)
        {
            // Arrange
            var sut = new CalculateSurfaceAreaInteractor();

            // Act
            var result = sut.Handle(input);

            // Assert
            Assert.Equal(result, expected);

        }
    }
}
