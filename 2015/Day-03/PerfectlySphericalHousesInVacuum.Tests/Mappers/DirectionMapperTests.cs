using PerfectlySphericalHousesInVacuum.Mappers;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.Mappers
{
    public class DirectionMapperTests
    {
        [Theory]
        [InlineData('^', Direction.Up)]
        [InlineData('v', Direction.Down)]
        [InlineData('<', Direction.Left)]
        [InlineData('>', Direction.Right)]
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