using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Interactors
{
    public class GetFloorsInteractor(IFileManager fileManager) : IGetFloorsInteractor
    {
        public int Handle(string filePath)
        {
            var floors = fileManager.ReadFile(filePath);
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
