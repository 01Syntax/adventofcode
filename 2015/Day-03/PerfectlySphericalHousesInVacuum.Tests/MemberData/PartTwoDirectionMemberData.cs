using PerfectlySphericalHousesInVacuum.Models;

namespace PerfectlySphericalHousesInVacuum.Tests.MemberData
{
    public class PartTwoDirectionMemberData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                new List<Direction> { Direction.Up, Direction.Down },
                3
            ],
            [
                new List<Direction> { Direction.Right, Direction.Left },
                3
            ],
            [
                new List<Direction> { Direction.Up, Direction.Right , Direction.Down , Direction.Left },
                3
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
                11
            ],
        ];
    }
}
