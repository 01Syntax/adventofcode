using IWasToldThereWouldBeNoMath.Interactors;
using IWasToldThereWouldBeNoMath.Models;
using IWasToldThereWouldBeNoMath.Tests.MemberData;

namespace IWasToldThereWouldBeNoMath.Tests.Interactors
{
    public class CalculateRibbonFeetInteractorTests
    {
        [Theory]
        [MemberData(nameof(RibbonMemberData.TestData), MemberType = typeof(RibbonMemberData))]
        public void Handle_ReturnsCorrectResult(List<Dimension> dimensions, int expected)
        {
            // Arrange
            var ribbonFeetsInteractor = new CalculateRibbonFeetInteractor();
            // Act
            var actual = ribbonFeetsInteractor.Handle(dimensions);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
