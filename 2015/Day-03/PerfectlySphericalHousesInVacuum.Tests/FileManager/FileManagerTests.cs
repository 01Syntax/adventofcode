using Moq;
using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.FileManager
{
    public class FileManagerTests
    {
        [Theory]
        [InlineData('v', Direction.Down)]
        public void ReadFile_ReturnFileContent(char input, Direction expected)
        {
            // Arrange
            var directionMapper = new Mock<IDirectionMapper>();
            directionMapper.Setup(x => x.MapToDirection(input)).Returns(expected);
            var sut = new PerfectlySphericalHousesInVacuum.FileManager.FileManager(directionMapper.Object);
            var filePath = Path.Combine("MockData", "test.txt");

            // Act
            var content = sut.ReadFile(filePath);

            // Assert
            Assert.Equivalent(
                new[]
                {
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down
                }, content);
        }


        [Fact]
        public void ReadFile_ThrowAnException()
        {
            // Arrange
            var directionMapper = new Mock<IDirectionMapper>();
            var sut = new PerfectlySphericalHousesInVacuum.FileManager.FileManager(directionMapper.Object);
            var filePath = Path.Combine("MockData", "nonexistent.txt");

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => sut.ReadFile(filePath));
        }
    }
}