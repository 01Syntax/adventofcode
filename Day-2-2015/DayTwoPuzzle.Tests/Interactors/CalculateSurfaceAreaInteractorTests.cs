using DayTwoPuzzle.Interactors;
using DayTwoPuzzle.Models;
using DayTwoPuzzle.Tests.MemberData;

namespace DayTwoPuzzle.Tests.Interactors
{
    public class CalculateSurfaceAreaInteractorTests
    {
        [Theory]
        [MemberData(nameof(DimensionsMemberData.TestData), MemberType = typeof(DimensionsMemberData))]
        public void Handle_ReturnsTotalWrappingPaper(IEnumerable<Dimension> input, int expected)
        {
            var sut = new CalculateSurfaceAreaInteractor();
            var result = sut.Handle(input);
            Assert.Equal(expected, result);
        }
    }
}
