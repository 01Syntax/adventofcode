namespace DayTwoPuzzle.Tests.MemberData
{
    public class ArraySorterData
    {
        public static IEnumerable<object[]> TestData =>
        [
            [
                new[,]
                {
                    { 27, 2, 5 },
                    { 6, 10, 13 },
                    { 15, 19, 10 }
                },
                new[,]
                {
                    { 2, 5, 27 },
                    { 6, 10, 13 },
                    { 10, 15, 19 }
                }
            ],

            [
                new [,]
                {
                    { 20, 28, 3},
                    { 29, 13, 26 },
                    { 11, 11, 14 },

                },
                new [,]
                {
                    { 3, 20, 28},
                    { 13, 26, 29 },
                    { 11, 11, 14 }
                }
            ],
        ];
    }
}
