using DoesntHeHaveIntern_ElvesForThis.Interfaces;

namespace DoesntHeHaveIntern_ElvesForThis.Interactors
{
    public class GetTotalNiceStringsInteractor : IGetTotalNiceStringsInteractor
    {
        public async Task<int> Handle(List<string> niceStrings)
        {
            return await Task.FromResult(niceStrings.Count);
        }
    }
}
