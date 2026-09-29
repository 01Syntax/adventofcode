using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Logic
{
    public class GetTotalBrightnessLogic : IGetTotalBrightnessLogic
    {
        public int Handle(List<Instruction> instructions)
        {
            var brightness = new int[1000, 1000];

            foreach (var instruction in instructions)
            {
                for (int x = instruction.Start.X; x <= instruction.End.X; x++)
                {
                    for (int y = instruction.Start.Y; y <= instruction.End.Y; y++)
                    {
                        switch (instruction.Action)
                        {
                            case LightAction.TurnOn:
                                brightness[x, y] += 1;
                                break;
                            case LightAction.TurnOff:
                                if (brightness[x, y] > 0)
                                    brightness[x, y] -= 1;
                                break;
                            case LightAction.Toggle:
                                brightness[x, y] += 2;
                                break;
                        }
                    }
                }
            }

            var total = 0;
            foreach (var value in brightness)
                total += value;

            return total;
        }
    }
}
