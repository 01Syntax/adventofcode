using PerfectlySphericalHousesInVacuum.Interfaces;
using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Mappers
{
    public class DirectionMapper : IDirectionMapper
    {
        public Direction MapToDirection(char direction)
        {
            return direction switch
            {
                '^' => Direction.Up,
                'v' => Direction.Down,
                '<' => Direction.Left,
                '>' => Direction.Right,
                _ => throw new ArgumentException("Invalid direction")
            };
        }
    }
}