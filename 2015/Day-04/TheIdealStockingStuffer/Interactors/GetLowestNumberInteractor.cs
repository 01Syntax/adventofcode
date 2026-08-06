using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Interactors
{
    public class GetLowestNumberInteractor(IGenerateHashHelper generateHashHelper) : IGetLowestNumberInteractor
    {
        public int Handle(string secretKey)
        {
            int number = 0;
            while (true)
            {
                string input = $"{secretKey}{number}";
                var hash = generateHashHelper.GenerateHash(input);

                // for part two just add an extra 0 to the start of the string to check for 6 leading zeros
                if (hash.StartsWith("000000"))
                {
                    return number;
                }

                number++;
            }
        }
    }
}
