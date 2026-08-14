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
            Assert.Equivalent(new List<string> {
                "turn on 887,9 through 959,629",
                "turn on 454,398 through 844,448",
                "turn off 539,243 through 559,965",
                "turn off 370,819 through 676,868" }, results);
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
