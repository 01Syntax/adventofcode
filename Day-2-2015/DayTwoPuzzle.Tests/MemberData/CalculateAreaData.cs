namespace DayTwoPuzzle.Tests.MemberData
{
    public class CalculateAreaData
    {
        public static IEnumerable<object[]> TestData() =>
        [
            [
                new[,]
                {
                    {2,3,4}
                },
                6
            ],

            [
                new[,]
                {
                    {1,1,10}
                },
                1
            ]
        ];
    }
}
