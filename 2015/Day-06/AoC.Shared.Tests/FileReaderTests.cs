namespace AoC.Shared.Tests
{
    public class FileReaderTests
    {
        [Fact]
        public void ReadFile_ReturnListOfInstructions()
        {
            // Arrange
            var sut = new FileReader();

            // Act

            var results = sut.ReadAsLines("DataSource/instruction.txt");

            // Assert
            Assert.Equivalent(new List<string> { "turn on 0,0 through 999,999", "toggle 0,0 through 999,999", "turn off 499,499 through 500,500" }, results);
        }

        [Fact]
        public void ReadFile_ThrowsExceptionWhenFileNotExists()
        {
            // Arrange
            var sut = new FileReader();

            // Act & Assert
            Assert.Throws<FileNotFoundException>(() => sut.ReadAsLines("noTxt.txt"));
        }
    }
}
