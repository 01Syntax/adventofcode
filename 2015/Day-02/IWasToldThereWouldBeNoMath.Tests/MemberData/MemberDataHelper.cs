using IWasToldThereWouldBeNoMath.Models;

namespace IWasToldThereWouldBeNoMath.Tests.MemberData
{
    public class MemberDataHelper
    {
        public static IEnumerable<object[]> TestData =>
        [
            [
                "29x13x26\r\n11x11x14",
                new List<Dimension> { new(29, 13, 26), new(11, 11, 14) }
            ],
            [
                "27x2x5\r\n6x10x13\r\n15x19x10",
                new List<Dimension> { new(27, 2, 5), new(6, 10, 13), new(15, 19, 10) }
            ]
        ];
    }
}
