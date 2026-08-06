namespace IWasToldThereWouldBeNoMath.Managers
{
    public interface IFileManager
    {
        Task<List<string>> ReadFile(string filePath);
    }
}
