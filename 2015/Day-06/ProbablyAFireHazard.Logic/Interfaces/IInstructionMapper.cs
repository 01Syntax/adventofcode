using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Interfaces
{
    public interface IInstructionMapper
    {
        List<Instruction> Map(string[,] lines);
    }
}
