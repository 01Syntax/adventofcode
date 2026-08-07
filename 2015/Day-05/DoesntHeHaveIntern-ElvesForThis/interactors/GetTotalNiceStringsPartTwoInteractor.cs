using DoesntHeHaveIntern_ElvesForThis.Interfaces;

namespace DoesntHeHaveIntern_ElvesForThis.interactors
{
    public class GetTotalNiceStringsPartTwoInteractor : IGetTotalNiceStringsPartTwoInteractor
    {
        public async Task<int> Handle(List<string> niceStrings)
        {
            return await Task.FromResult(niceStrings.Count);
        }
    }
}