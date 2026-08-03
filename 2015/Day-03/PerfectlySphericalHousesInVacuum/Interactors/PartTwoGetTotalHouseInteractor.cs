using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interactors
{
    public class PartTwoGetTotalHouseInteractor : IPartTwoGetTotalHouseInteractor
    {
        public int Handle(List<Direction> directions)
        {
            Dictionary<(int x, int y), int> visitedHouses = new()
            {
                {(0, 0) , 1}
            };


            var santaCurrentPosition = (x: 0, y: 0);
            var robotCurrentPosition = (x: 0, y: 0);
            bool santaTurn = true;

            foreach (var direction in directions)
            {
                if (santaTurn)
                {
                    switch (direction)
                    {
                        case Direction.Up:
                            santaCurrentPosition = (santaCurrentPosition.x, santaCurrentPosition.y + 1);
                            break;
                        case Direction.Down:
                            santaCurrentPosition = (santaCurrentPosition.x, santaCurrentPosition.y - 1);
                            break;
                        case Direction.Right:
                            santaCurrentPosition = (santaCurrentPosition.x + 1, santaCurrentPosition.y);
                            break;
                        case Direction.Left:
                            santaCurrentPosition = (santaCurrentPosition.x - 1, santaCurrentPosition.y);
                            break;
                    }

                    if (visitedHouses.TryGetValue(santaCurrentPosition, out var count))
                    {
                        visitedHouses[santaCurrentPosition] = count + 1;
                    }
                    else
                    {
                        visitedHouses[santaCurrentPosition] = 1;
                    }
                }
                else
                {
                    switch (direction)
                    {
                        case Direction.Up:
                            robotCurrentPosition = (robotCurrentPosition.x, robotCurrentPosition.y + 1);
                            break;
                        case Direction.Down:
                            robotCurrentPosition = (robotCurrentPosition.x, robotCurrentPosition.y - 1);
                            break;
                        case Direction.Right:
                            robotCurrentPosition = (robotCurrentPosition.x + 1, robotCurrentPosition.y);
                            break;
                        case Direction.Left:
                            robotCurrentPosition = (robotCurrentPosition.x - 1, robotCurrentPosition.y);
                            break;
                    }

                    if (visitedHouses.TryGetValue(robotCurrentPosition, out var count))
                    {
                        visitedHouses[robotCurrentPosition] = count + 1;
                    }
                    else
                    {
                        visitedHouses[robotCurrentPosition] = 1;
                    }

                }
                santaTurn = !santaTurn;
            }

            return visitedHouses.Count;
        }
    }
}
