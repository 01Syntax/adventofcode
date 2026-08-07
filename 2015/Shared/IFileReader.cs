namespace AoC.Shared;

public interface IFileReader
{
    string ReadAsString(string filePath);
    IEnumerable<string> ReadAsLines(string filePath);
    IEnumerable<T> ReadAs<T>(string filePath, Func<string, T> mapper);
}
