using ProbablyAFireHazard.Logic.Helpers;
using ProbablyAFireHazard.Logic.Models;
using ProbablyAFireHazard.Logic.Tests.MemberData;

namespace ProbablyAFireHazard.Logic.Tests.Helpers
{
    public class ConvertTo2DArrTests
    {
        [Theory]
        [MemberData(nameof(Arr2DDataMember.Get2D), MemberType = typeof(Arr2DDataMember))]
        public void ConvertTo2DArr_Should_Return_Correct_2D_Array(List<Instruction> instructions, string[,] expected)
        {
            // Arrange
            var sut = new ConvertTo2DArr();

            // Act
            var results = sut.Convert(instructions);

            // Assert
            Assert.Equal(expected, results);
        }
    }
}
