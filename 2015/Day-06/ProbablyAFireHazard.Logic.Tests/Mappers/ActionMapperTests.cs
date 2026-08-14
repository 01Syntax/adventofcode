using ProbablyAFireHazard.Logic.Mappers;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Tests.Mappers
{
    public class ActionMapperTests
    {
        [Fact]
        public void MapAction_ValidActions_ReturnsExpectedEnum()
        {
            // Arrange
            var sut = new ActionMapper();
            // Act & Assert
            Assert.Equal(LightAction.TurnOn, sut.MapAction("on"));
            Assert.Equal(LightAction.TurnOff, sut.MapAction("off"));
            Assert.Equal(LightAction.Toggle, sut.MapAction("toggle"));
        }
    }
}