using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Logic
{
    public class GetLightsOnLogic : IGetLightsOnLogic
    {
        public int Handle(List<Instruction> instructions)
        {
            var lightsOn = new HashSet<(int x, int y)>();

            foreach (var instruction in instructions)
            {
                for (int x = instruction.Start.X; x <= instruction.End.X; x++)
                {
                    for (int y = instruction.Start.Y; y <= instruction.End.Y; y++)
                    {
                        switch (instruction.Action)
                        {
                            case LightAction.TurnOn:
                                lightsOn.Add((x, y));
                                break;
                            case LightAction.TurnOff:
                                lightsOn.Remove((x, y));
                                break;
                            case LightAction.Toggle:
                                if (!lightsOn.Remove((x, y)))
                                    lightsOn.Add((x, y));
                                break;
                        }
                    }
                }
            }

            return lightsOn.Count;
        }
    }
}
