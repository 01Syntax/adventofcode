using System.Security.Cryptography;
using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer.Helpers
{
    public class MdManager : IMdManager
    {
        public MD5 CreateHash()
        {
            return MD5.Create();
        }
    }
}