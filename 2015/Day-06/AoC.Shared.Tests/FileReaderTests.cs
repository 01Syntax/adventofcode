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

            var results = sut.ReadAs("DataSource/instruction.txt", (instruction) => line);

            // Assert
        }
    }
}
