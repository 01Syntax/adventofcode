using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.FileManager
{
    public class FileManagerTests
    {
        [Fact]
        public void ReadFile_ReturnFileContent()
        {
            // Arrange
            var sut = new PerfectlySphericalHousesInVacuum.FileManager.FileManager();
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
            var sut = new PerfectlySphericalHousesInVacuum.FileManager.FileManager();
            var filePath = Path.Combine("MockData", "nonexistent.txt");

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => sut.ReadFile(filePath));
        }
    }
}