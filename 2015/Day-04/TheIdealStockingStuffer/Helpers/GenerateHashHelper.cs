using System.Text;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Helpers
{
    public class GenerateHashHelper(IMdManager mdManager)
    {
        public static string GenerateHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = mdManager.CreateHash(input).ComputeHash(inputBytes);

            string hash = Convert.ToHexString(hashBytes).ToLower();
        }
    }
}
