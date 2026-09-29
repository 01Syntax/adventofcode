using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Interfaces
{
    public interface IGetTotalBrightnessLogic
    {
        int Handle(List<Instruction> instructions);
    }
}
