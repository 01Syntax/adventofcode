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
            var filePath = Path.Combine("DataSource", "test.txt");

            // act
            var content = sut.ReadFile(filePath);

            // Assert
            Assert.Equivalent(content, "zgsnvdmlfuplrubt\r\nvlhagaovgqjmgvwq\r\nffumlmqwfcsyqpss\r\nzztdcqzqddaazdjp");
        }

        [Fact]
        public void ReadFile_ThrowsAnExceptionWhenFileNotExists()
        {
            // Arrange
            var sut = new FileManager();
            var filePath = Path.Combine("DataSource", "notExists.txt");


            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => sut.ReadFile(filePath));
        }
    }
}
