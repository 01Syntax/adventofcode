using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interactors
{
    public class GetTotalHouseInteractor : IGetTotalHouseInteractor
    {
        public int Handle(List<Direction> directions)
        {
            Dictionary<(int x, int y), int> visitedHouses = new()
            {
                {(0, 0) , 1}
            };

            var currentPosition = (x: 0, y: 0);
            foreach (var direction in directions)
            {
                switch (direction)
                {
                    case Direction.Up:
                        currentPosition = (currentPosition.x, currentPosition.y + 1);
                        break;
                    case Direction.Down:
                        currentPosition = (currentPosition.x, currentPosition.y - 1);
                        break;
                    case Direction.Right:
                        currentPosition = (currentPosition.x + 1, currentPosition.y);
                        break;
                    case Direction.Left:
                        currentPosition = (currentPosition.x - 1, currentPosition.y);
                        break;
                }

                if (visitedHouses.TryGetValue(currentPosition, out var count))
                {
                    visitedHouses[currentPosition] = count + 1;
                }
                else
                {
                    visitedHouses[currentPosition] = 1;
                }
            }

            return visitedHouses.Count;
        }
    }
}