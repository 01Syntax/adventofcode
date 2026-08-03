using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Mappers
{
    public class DirectionMapper
    {
        public Direction MapToDirection(char direction)
        {
            return direction switch
            {
                '^' => Direction.North,
                'v' => Direction.South,
                '<' => Direction.West,
                '>' => Direction.East,
                _ => throw new ArgumentException("Invalid direction")
            };
        }
    }
}