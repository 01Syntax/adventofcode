using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Interactors
{
    public class GetTotalHouseInteractor
    {
        public int GetTotalDeliveries(List<Direction> directions)
        {
            var numberOfDeliveriesToHouses = 0;

            for (int i = 0; i < directions.Count; i++)
            {
                if (directions[i] == Direction.Up && directions[i + 1] == Direction.Down || directions[i] == Direction.Right && directions[i + 1] == Direction.Left || directions[i] == Direction.Down && directions[i + 1] == Direction.Up || directions[i] == Direction.Left && directions[i + 1] == Direction.Right)
                {
                    numberOfDeliveriesToHouses++;
                    break;
                }

                if (directions[i] == Direction.Up && directions[i + 1] == Direction.Right || directions[i] == Direction.Down && directions[i + 1] == Direction.Left)
                {
                    numberOfDeliveriesToHouses++;
                    break;
                }

                if (directions[i] == Direction.Up && directions[i + 1] == Direction.Down && directions[i + 2] == Direction.Up && directions[i + 3] == Direction.Down)
                {
                    numberOfDeliveriesToHouses = 2;
                    break;
                }
            }
            return numberOfDeliveriesToHouses;
        }
    }
}