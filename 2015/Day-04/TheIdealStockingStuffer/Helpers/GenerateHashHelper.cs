using System.Text;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Helpers
{
    public class GenerateHashHelper(IMdManager mdManager)
    {
        public string GenerateHash(string input)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = mdManager.CreateHash().ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes).ToLower();
        }
    }
}
