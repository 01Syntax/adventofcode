using PerfectlySphericalHousesInVacuum.Interactors;
using PerfectlySphericalHousesInVacuum.Models;
using PerfectlySphericalHousesInVacuum.Tests.MemberData;

namespace PerfectlySphericalHousesInVacuum.Tests.Interactors
{
    public class GetTotalHouseInteractorTests
    {
        [Theory]
        [MemberData(nameof(DirectionMemberData.TestData), MemberType = typeof(DirectionMemberData))]
        public void GetTotalHouses_WhenCalledWithValidInput_ReturnsCorrectTotalHouses(List<Direction> directions,
            int expectedTotalHouses)
        {
            // Arrange
            var interactor = new GetTotalHouseInteractor();

            // Act
            var actualTotalHouses = interactor.GetTotalDeliveries(directions);

            // Assert
            Assert.Equal(expectedTotalHouses, actualTotalHouses);
        }
    }
}
