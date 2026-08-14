namespace AoC.Shared.Tests;

public class FileReaderTests : IDisposable
{
    private readonly FileReader _sut = new();
    private readonly string _tempFile;

    public FileReaderTests()
    {
        _tempFile = Path.GetTempFileName();
    }

    public void Dispose()
    {
        if (File.Exists(_tempFile))
            File.Delete(_tempFile);
    }

    [Fact]
    public void ReadAsString_ReturnsFileContent()
    {
        File.WriteAllText(_tempFile, "hello world");

        var result = _sut.ReadAsString(_tempFile);

        Assert.Equal("hello world", result);
    }

    [Fact]
    public void ReadAsString_ThrowsFileNotFoundException_WhenFileDoesNotExist()
    {
        var nonExistentPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

        Assert.Throws<FileNotFoundException>(() => _sut.ReadAsString(nonExistentPath));
    }

    [Fact]
    public void ReadAsLines_ReturnsEachLineAsElement()
    {
        File.WriteAllLines(_tempFile, ["line one", "line two", "line three"]);

        var result = _sut.ReadAsLines(_tempFile);

        Assert.Equal(["line one", "line two", "line three"], result);
    }

    [Fact]
    public void ReadAsLines_ThrowsFileNotFoundException_WhenFileDoesNotExist()
    {
        var nonExistentPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

        Assert.Throws<FileNotFoundException>(() => _sut.ReadAsLines(nonExistentPath));
    }

    [Fact]
    public void ReadAs_MapsEachLineUsingMapper()
    {
        File.WriteAllLines(_tempFile, ["1", "2", "3"]);

        var result = _sut.ReadAs(_tempFile, int.Parse);

        Assert.Equal([1, 2, 3], result);
    }

    [Fact]
    public void ReadAs_ThrowsFileNotFoundException_WhenFileDoesNotExist()
    {
        var nonExistentPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

        Assert.Throws<FileNotFoundException>(() => _sut.ReadAs(nonExistentPath, line => line));
    }
}
