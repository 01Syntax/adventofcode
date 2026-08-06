namespace DoesntHeHaveIntern_ElvesForThis.Interfaces;

public interface IGetTotalNiceStringsInteractor
{
    Task<int> Handle(List<string> niceStrings);
}