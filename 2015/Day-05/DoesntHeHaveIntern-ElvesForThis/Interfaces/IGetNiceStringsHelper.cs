namespace DoesntHeHaveIntern_ElvesForThis.Interfaces;

public interface IGetNiceStringsHelper
{
    Task<List<string>> GetNiceStrings(List<string> dataList);
}