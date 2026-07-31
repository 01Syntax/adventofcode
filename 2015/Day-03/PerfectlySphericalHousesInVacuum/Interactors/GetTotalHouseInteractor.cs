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
                if (directions[i] == Direction.North && directions[i + 1] == Direction.South || directions[i] == Direction.East && directions[i + 1] == Direction.West || directions[i] == Direction.South && directions[i + 1] == Direction.North || directions[i] == Direction.West && directions[i + 1] == Direction.East)
                {
                    numberOfDeliveriesToHouses++;
                    break;
                }

                if (directions[i] == Direction.North && directions[i + 1] == Direction.East || directions[i] == Direction.South && directions[i + 1] == Direction.West)
                {
                    numberOfDeliveriesToHouses++;
                    break;
                }

                if (directions[i] == Direction.North && directions[i + 1] == Direction.South && directions[i + 2] == Direction.North && directions[i + 3] == Direction.South)
                {
                    numberOfDeliveriesToHouses = 2;
                    break;
                }
            }
            return numberOfDeliveriesToHouses;
        }
    }
}