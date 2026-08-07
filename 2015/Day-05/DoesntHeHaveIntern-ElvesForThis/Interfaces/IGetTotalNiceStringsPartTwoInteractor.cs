namespace DoesntHeHaveIntern_ElvesForThis.Interfaces
{
    public interface IGetTotalNiceStringsPartTwoInteractor
    {
        Task<int> Handle(List<string> niceStrings);
    }
}