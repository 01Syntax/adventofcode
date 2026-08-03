using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.MemberData
{
    public class DirectionMemberData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                new List<Direction> { Direction.North, Direction.South },
                1
            ],
            [
                new List<Direction> { Direction.East, Direction.West },
                1
            ],
            [
                new List<Direction> { Direction.North, Direction.East , Direction.South , Direction.West },
                1
            ],
            [
                new List<Direction>
                {
                    Direction.North,
                    Direction.South,
                    Direction.North,
                    Direction.South,
                    Direction.North,
                    Direction.South,
                    Direction.North,
                    Direction.South,
                    Direction.North,
                    Direction.South
                },
                2
            ],
        ];
    }
}