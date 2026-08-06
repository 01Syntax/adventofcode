using DoesntHeHaveIntern_ElvesForThis.Interfaces;
using IWasToldThereWouldBeNoMath.Managers;

namespace DoesntHeHaveIntern_ElvesForThis
{
    public class App(IGetNiceStringsHelper getNiceStringsHelper, IGetTotalNiceStringsInteractor getTotalNiceStringsInteractor, IFileManager fileManager)
    {
        public async Task Run()
        {
            var dataList = await fileManager.ReadFile("DataSource/data.txt");
            var niceStrings = await getNiceStringsHelper.GetNiceStrings(dataList);
            var totalNiceStrings = await getTotalNiceStringsInteractor.Handle(niceStrings);
            Console.WriteLine($"Total nice strings: {totalNiceStrings}");
        }
    }
}
