using DayTwoPuzzle.Helpers;
using DayTwoPuzzle.Tests.MemberData;

namespace DayTwoPuzzle.Tests.Helpers
{
    public class ArraySorterTests
    {
        [Theory]
        [MemberData(nameof(ArraySorterData.TestData), MemberType = typeof(ArraySorterData))]
        public void Sort2DArray_ReturnsSorted2DArray(int[,] data, int[,] expected)
        {
            // Arrange 
            var arraySorter = new ArraySorter();

            // Act
            var actual = arraySorter.Sort2DArray(data);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
