using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Interfaces
{
    public interface IActionMapper
    {
        LightAction MapAction(string action);
    }
}
