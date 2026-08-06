using System.Security.Cryptography;

namespace TheIdealStockingStuffer.Interfaces
{
    public interface IMdManager
    {
        MD5 CreateHash(string input);
    }
}
