using TheIdealStockingStuffer.Interfaces;

namespace TheIdealStockingStuffer
{
    public class App(IGetLowestNumberInteractor getLowestNumberInteractor)
    {
        public void Run(string secretKey)
        {
            int lowestNumber = getLowestNumberInteractor.Handle(secretKey);
            Console.WriteLine($"The lowest number for the secret key '{secretKey}' is: {lowestNumber}");
        }
    }
}
