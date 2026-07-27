using NotQuiteLisp.Interfaces;

namespace NotQuiteLisp.Managers
{
    public class App(IGetFloorsInteractor interactor, IGetPositionOfCharacterInteractor positionInteractor)
    {
        public void Run()
        {
            var floor = interactor.Handle("floors.txt");
            var position = positionInteractor.Handle("floors.txt");
            Console.WriteLine($"Santa ends on floor {floor}");
            Console.WriteLine($"Santa first enters the basement at position {position}");
        }
    }
}
