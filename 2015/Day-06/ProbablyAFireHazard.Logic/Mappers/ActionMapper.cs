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
                "on" => LightAction.TurnOn,
                "off" => LightAction.TurnOff,
                "toggle" => LightAction.Toggle,
                _ => throw new ArgumentException($"Invalid action: {action}")
            };
        }
    }
}
