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
            Assert.Equivalent("^v^v^v^v^v", content);
        }
    }
}