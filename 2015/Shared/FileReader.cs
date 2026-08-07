namespace AoC.Shared;

public class FileReader : IFileReader
{
    public string ReadAsString(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}", filePath);
        return File.ReadAllText(filePath);
    }

    public IEnumerable<string> ReadAsLines(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException($"File not found: {filePath}", filePath);
        return File.ReadAllLines(filePath);
    }

    public IEnumerable<T> ReadAs<T>(string filePath, Func<string, T> mapper)
    {
        return ReadAsLines(filePath).Select(mapper);
    }
}
