using IWasToldThereWouldBeNoMath.Managers;

namespace IWasToldThereWouldBeNoMath.Tests.Managers
{
    public class FileManagerTests
    {
        [Fact]
        public void ReadFile_ReturnTheFileContent()
        {
            // Arrange
            var sut = new FileManager();
            var filePath = Path.Combine("MockData", "dimensions.txt");

            // act
            var content = sut.ReadFile(filePath);

            // Assert
            Assert.Equivalent(content, "29x13x26\r\n11x11x14\r\n27x2x5");
        }

        [Fact]
        public void ReadFile_ThrowsAnExceptionWhenFileNotExists()
        {
            // Arrange
            var sut = new FileManager();
            var filePath = Path.Combine("MockData", "notExists.txt");


            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => sut.ReadFile(filePath));
        }
    }
}
