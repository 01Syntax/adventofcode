using ProbablyAFireHazard.Logic.Logic;
using ProbablyAFireHazard.Logic.Models;
using ProbablyAFireHazard.Logic.Tests.MemberData;

namespace ProbablyAFireHazard.Logic.Tests.Logic
{
    public class GetTotalBrightnessLogicTests
    {
        [Theory]
        [MemberData(nameof(BrightnessDataMember.GetData), MemberType = typeof(BrightnessDataMember))]
        public void Handle_ReturnsTotalBrightness(List<Instruction> instructions, int expectedTotal)
        {
            // Arrange
            var sut = new GetTotalBrightnessLogic();

            // Act
            var total = sut.Handle(instructions);

            // Assert
            Assert.Equal(expectedTotal, total);
        }
    }
}
