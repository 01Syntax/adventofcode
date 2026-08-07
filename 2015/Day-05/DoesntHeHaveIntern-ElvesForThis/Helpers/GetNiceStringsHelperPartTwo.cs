using DoesntHeHaveIntern_ElvesForThis.Interfaces;

namespace DoesntHeHaveIntern_ElvesForThis.Helpers
{
    public class GetNiceStringsHelperPartTwo : IGetNiceStringsHelperPartTwo
    {
        public async Task<List<string>> GetNiceStrings(List<string> input)
        {
            var niceStrings = new List<string>();

            foreach (var str in input)
            {
                if (await HasPairOfTwoLettersThatAppearsTwice(str) && await HasLetterThatRepeatsWithExactlyOneLetterBetween(str))
                {
                    niceStrings.Add(str);
                }
            }

            return niceStrings;
        }

        async Task<bool> HasPairOfTwoLettersThatAppearsTwice(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                string pair = input.Substring(i, 2);
                if (input.IndexOf(pair, i + 2) != -1)
                {
                    return true;
                }
            }
            return false;
        }

        async Task<bool> HasLetterThatRepeatsWithExactlyOneLetterBetween(string input)
        {
            for (int i = 0; i < input.Length - 2; i++)
            {
                if (input[i] == input[i + 2])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
