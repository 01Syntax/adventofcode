using AoC.Shared;
using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Interactors
{
    public class GetFloorsInteractor(IFileReader fileReader) : IGetFloorsInteractor
    {
        public int Handle(string filePath)
        {
            var floors = fileReader.ReadAsString(filePath);
            var counter = 0;

            foreach (var floor in floors)
            {
                if (floor == '(')
                {
                    counter++;
                }
                else if (floor == ')')
                {
                    counter--;
                }
            }
            return counter;
        }
    }
}
