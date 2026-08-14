namespace AoC.Shared.Tests;

public class FileReaderTests
{
    private readonly FileReader _sut = new();
    private static readonly string InstructionFile = Path.Combine(AppContext.BaseDirectory, "TestData", "instruction.txt");

    private static readonly string[] ExpectedLines =
    [
        "turn on 0,0 through 999,999",
        "turn on 100,100 through 200,200",
        "turn on 500,500 through 750,750",
        "turn off 250,250 through 300,300"
    ];

    [Fact]
    public void ReadAsString_ReturnsFileContent()
    {
        var result = _sut.ReadAsString(InstructionFile);

        Assert.Contains("turn on 0,0 through 999,999", result);
        Assert.Contains("turn off 250,250 through 300,300", result);
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
        var result = _sut.ReadAsLines(InstructionFile);

        Assert.Equal(ExpectedLines, result);
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
        var result = _sut.ReadAs(InstructionFile, line => line.Split(' ')[0]);

        Assert.Equal(["turn", "turn", "turn", "turn"], result);
    }

    [Fact]
    public void ReadAs_ThrowsFileNotFoundException_WhenFileDoesNotExist()
    {
        var nonExistentPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());

        Assert.Throws<FileNotFoundException>(() => _sut.ReadAs(nonExistentPath, line => line));
    }
}
