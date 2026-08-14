using Moq;
using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Mappers;
using ProbablyAFireHazard.Logic.Models;
using ProbablyAFireHazard.Logic.Tests.MemberData;

namespace ProbablyAFireHazard.Logic.Tests.Mappers
{
    public class InstructionMapperTests
    {
        [Theory]
        [MemberData(nameof(InstructionsDataMember.GetInstructions), MemberType = typeof(InstructionsDataMember))]
        public void Map_ReturnListOfInstruction(string[,] input, List<Instruction> expected)
        {
            // Arrange
            var mock = new Mock<IActionMapper>();
            mock.Setup(x => x.MapAction(It.IsAny<string>()))
                .Returns((string action) =>
                {
                    return action switch
                    {
                        "on" => LightAction.TurnOn,
                        "off" => LightAction.TurnOff,
                        "toggle" => LightAction.Toggle,
                        _ => throw new ArgumentOutOfRangeException(nameof(action), $"Unknown action: {action}")
                    };
                });
            var sut = new InstructionMapper(mock.Object);

            // Act
            var result = sut.Map(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
