using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.MemberData
{
    public class DirectionMemberData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                new List<Direction> { Direction.Up, Direction.Down },
                1
            ],
            [
                new List<Direction> { Direction.Right, Direction.Left },
                1
            ],
            [
                new List<Direction> { Direction.Up, Direction.Right , Direction.Down , Direction.Left },
                1
            ],
            [
                new List<Direction>
                {
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down,
                    Direction.Up,
                    Direction.Down
                },
                2
            ],
        ];
    }
}