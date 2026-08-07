using AoC.Shared;

namespace NotQuiteLisp.Tests.Managers
{
    public class FileReaderTests
    {
        [Fact]
        public void ReadAsString_ReturnsCorrectContent()
        {
            var sut = new FileReader();
            var path = Path.Combine("MockData", "floors.txt");

            var result = sut.ReadAsString(path);

            Assert.Equivalent(result, "()(((()))(()(");
        }

        [Fact]
        public void ReadAsString_ThrowsWhenFileNotFound()
        {
            var sut = new FileReader();

            Assert.Throws<FileNotFoundException>(() => sut.ReadAsString("nonexistent.txt"));
        }

        [Fact]
        public void ReadAsLines_ReturnsEachLine()
        {
            var sut = new FileReader();
            var path = Path.Combine("MockData", "floors.txt");

            var result = sut.ReadAsLines(path).ToList();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void ReadAs_MapsEachLine()
        {
            var sut = new FileReader();
            var path = Path.Combine("MockData", "floors.txt");

            var result = sut.ReadAs(path, line => line.Length).ToList();

            Assert.NotEmpty(result);
        }
    }
}
