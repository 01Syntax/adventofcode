using DoesntHeHaveIntern_ElvesForThis.Interfaces;
using IWasToldThereWouldBeNoMath.Managers;

namespace DoesntHeHaveIntern_ElvesForThis
{
    public class App(IGetNiceStringsHelper getNiceStringsHelper, IGetTotalNiceStringsInteractor getTotalNiceStringsInteractor, IFileManager fileManager, IGetTotalNiceStringsPartTwoInteractor getTotalNiceStringsPartTwoInteractor, IGetNiceStringsHelperPartTwo getNiceStringsHelperPartTwo)
    {
        public async Task Run()
        {
            var dataList = await fileManager.ReadFile("DataSource/data.txt");
            var niceStrings = await getNiceStringsHelper.GetNiceStrings(dataList);
            var totalNiceStrings = await getTotalNiceStringsInteractor.Handle(niceStrings);
            var niceStringsPartTwo = await getNiceStringsHelperPartTwo.GetNiceStrings(dataList);
            var totalNiceStringsPartTwo = await getTotalNiceStringsPartTwoInteractor.Handle(niceStringsPartTwo);
            Console.WriteLine($"Total nice strings (Part Two): {totalNiceStringsPartTwo}");
            Console.WriteLine($"Total nice strings: {totalNiceStrings}");
        }
    }
}
