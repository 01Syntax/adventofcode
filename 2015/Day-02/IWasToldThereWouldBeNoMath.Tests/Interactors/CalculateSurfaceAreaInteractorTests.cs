using IWasToldThereWouldBeNoMath.Interactors;
using IWasToldThereWouldBeNoMath.Models;
using IWasToldThereWouldBeNoMath.Tests.MemberData;

namespace IWasToldThereWouldBeNoMath.Tests.Interactors
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
