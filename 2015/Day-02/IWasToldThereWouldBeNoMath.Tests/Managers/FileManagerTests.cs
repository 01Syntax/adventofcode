using IWasToldThereWouldBeNoMath.Managers;

namespace IWasToldThereWouldBeNoMath.Tests.Managers
{
    public class FileManagerTests
    {
        [Fact]
        public async Task ReadFile_ReturnTheFileContent()
        {
            // Arrange
            var sut = new FileManager();
            var filePath = Path.Combine("DataSource", "test.txt");

            // act
            var content = await sut.ReadFile(filePath);

            // Assert
            Assert.Equivalent(content, new List<string>
            {
                "zgsnvdmlfuplrubt",
                "vlhagaovgqjmgvwq",
                "ffumlmqwfcsyqpss",
                "zztdcqzqddaazdjp"
            });
        }

        [Fact]
        public async Task ReadFile_ThrowsAnExceptionWhenFileNotExists()
        {
            // Arrange
            var sut = new FileManager();
            var filePath = Path.Combine("DataSource", "notExists.txt");


            // Act & Assert
            await Assert.ThrowsAsync<FileNotFoundException>(async () => await sut.ReadFile(filePath));
        }
    }
}
