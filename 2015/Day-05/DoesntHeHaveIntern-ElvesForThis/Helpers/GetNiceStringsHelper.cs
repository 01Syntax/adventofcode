using DoesntHeHaveIntern_ElvesForThis.Interfaces;

namespace DoesntHeHaveIntern_ElvesForThis.Helpers
{
    public class GetNiceStringsHelper : IGetNiceStringsHelper
    {
        public async Task<List<string>> GetNiceStrings(List<string> dataList)
        {
            var niceStrings = new List<string>();
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var forbiddenStrings = new[] { "ab", "cd", "pq", "xy" };

            return dataList.Where(input => HasEnoughVowels(input, vowels)
                                           && !ContainsForbiddenString(input, forbiddenStrings) &&
                                           HasDoubleLetter(input)).ToList();
        }

        private bool HasEnoughVowels(string input, char[] vowels)
        {
            return input.Count(c => vowels.Contains(c)) >= 3;
        }

        private bool ContainsForbiddenString(string input, string[] forbiddenStrings)
        {
            return forbiddenStrings.Any(input.Contains);
        }

        private bool HasDoubleLetter(string input)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
