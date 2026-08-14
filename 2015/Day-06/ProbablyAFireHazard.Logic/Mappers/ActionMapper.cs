using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Mappers
{
    public class ActionMapper : IActionMapper
    {
        public LightAction MapAction(string action)
        {
            return action switch
            {
                "turn on" => LightAction.TurnOn,
                "turn off" => LightAction.TurnOff,
                "toggle" => LightAction.Toggle,
                _ => throw new ArgumentException($"Invalid action: {action}")
            };
        }
    }
}
