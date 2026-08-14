using ProbablyAFireHazard.Logic.Logic;
using ProbablyAFireHazard.Logic.Models;
using ProbablyAFireHazard.Logic.Tests.MemberData;

namespace ProbablyAFireHazard.Logic.Tests.Logic
{
    public class GetLightsOnLogicTests
    {
        [Theory]
        [MemberData(nameof(OnInstructionsMember.GetOnInstructions), MemberType = typeof(OnInstructionsMember))]
        public void Handle_ReturnsListOfInstructionsWithOn(List<Instruction> instructions, int expectedCount)
        {
            // Arrange
            var sut = new GetLightsOnLogic();

            // Act
            var total = sut.Handle(instructions);

            // Assert
            Assert.Equal(expectedCount, total);
        }
    }
}
