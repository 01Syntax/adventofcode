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
            var sut = new InstructionMapper();

            // Act
            var result = sut.Map(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
