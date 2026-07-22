namespace DayTwoPuzzle.Tests.MemberData
{
    public class DimensionsMemberData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                10,
                new[, ]
                {
                    {2,3,4}
                }
            ],
            [
                4,
                new[,]
                {
                    {1,1,10}
                }
            ]
        ];
    }
}
