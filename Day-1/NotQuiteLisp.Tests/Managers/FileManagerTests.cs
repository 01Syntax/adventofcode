using NotQuiteLisp.Managers;

namespace NotQuiteLisp.Tests.Managers
{
    public class FileManagerTests
    {
        [Fact]
        public void ReadFile_ReturnsCorrectContent()
        {
            // Arrange
            var sut = new FileManager();
            var path = Path.Combine("MockData", "floors.txt");
            var floors = sut.ReadFile(path);

            // Act & Assert
            Assert.Equivalent(floors, "()(((()))(()(");
        }
    }
}