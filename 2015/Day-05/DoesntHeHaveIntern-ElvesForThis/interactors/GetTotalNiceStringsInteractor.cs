namespace DoesntHeHaveIntern_ElvesForThis.interactors
{
    public class GetTotalNiceStringsInteractor
    {
        public int Handle(List<String> niceStrings)
        {
            return niceStrings.Count;
        }
    }
}
