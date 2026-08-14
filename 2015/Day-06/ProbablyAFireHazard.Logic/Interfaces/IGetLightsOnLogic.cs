using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Interfaces
{
    public interface IGetLightsOnLogic
    {
        int Handle(List<Instruction> instructions);
    }
}
