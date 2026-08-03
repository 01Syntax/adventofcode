using PerfectlySphericalHousesInVacuum.Mappers;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.Mappers
{
    public class DirectionMapperTests
    {
        [Theory]
        [InlineData('^', Direction.North)]
        [InlineData('v', Direction.South)]
        [InlineData('<', Direction.West)]
        [InlineData('>', Direction.East)]
        public void MapToDirection_ReturnsCorrectDirection(char input, Direction expected)
        {
            // Arrange
            var sut = new DirectionMapper();

            // Act
            var result = sut.MapToDirection(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}