using PerfectlySphericalHousesInVacuum.Interactors;
using PerfectlySphericalHousesInVacuum.Models;
using PerfectlySphericalHousesInVacuum.Tests.MemberData;

namespace PerfectlySphericalHousesInVacuum.Tests.Interactors
{
    public class PartTwoGetTotalHouseInteractorTests
    {
        [Theory]
        [MemberData(nameof(PartTwoDirectionMemberData.TestData), MemberType = typeof(PartTwoDirectionMemberData))]
        public void GetTotalHouses_WhenCalledWithValidInput_ReturnsCorrectTotalHouses(List<Direction> directions,
            int expectedTotalHouses)
        {
            // Arrange
            var interactor = new PartTwoGetTotalHouseInteractor();

            // Act
            var actualTotalHouses = interactor.Handle(directions);

            // Assert
            Assert.Equal(expectedTotalHouses, actualTotalHouses);
        }
    }
}
