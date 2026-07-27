using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Tests.MemberData
{
    public class DimensionsMemberData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                new List<Dimension> { new(2, 3, 4) },
                58   // 2*(6+12+8) + min(6,12,8) = 52 + 6
            ],
            [
                new List<Dimension> { new(1, 1, 10) },
                43   // 2*(1+10+10) + min(1,10,10) = 42 + 1
            ]
        ];
    }
}
