using DayTwoPuzzle.Models;

namespace DayTwoPuzzle.Tests.MemberData
{
    public class RibbonMemberData
    {
        public static IEnumerable<object[]> TestData =>

        [
            [
                new List<Dimension>
                {
                    new Dimension(2, 3, 4)
                },
                34
            ],
            [
                new List<Dimension>
                {
                    new Dimension(1, 1, 10)
                },
                14
            ]
        ];
    }
}
