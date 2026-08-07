using AoC.Shared;
using DoesntHeHaveIntern_ElvesForThis.Interfaces;

namespace DoesntHeHaveIntern_ElvesForThis
{
    public class App(IGetNiceStringsHelper getNiceStringsHelper, IGetTotalNiceStringsInteractor getTotalNiceStringsInteractor, IFileReader fileReader, IGetTotalNiceStringsPartTwoInteractor getTotalNiceStringsPartTwoInteractor, IGetNiceStringsHelperPartTwo getNiceStringsHelperPartTwo)
    {
        public async Task Run()
        {
            var dataList = fileReader.ReadAsLines("DataSource/data.txt").ToList();
            var niceStrings = await getNiceStringsHelper.GetNiceStrings(dataList);
            var totalNiceStrings = await getTotalNiceStringsInteractor.Handle(niceStrings);
            var niceStringsPartTwo = await getNiceStringsHelperPartTwo.GetNiceStrings(dataList);
            var totalNiceStringsPartTwo = await getTotalNiceStringsPartTwoInteractor.Handle(niceStringsPartTwo);
            Console.WriteLine($"Total nice strings (Part Two): {totalNiceStringsPartTwo}");
            Console.WriteLine($"Total nice strings: {totalNiceStrings}");
        }
    }
}
