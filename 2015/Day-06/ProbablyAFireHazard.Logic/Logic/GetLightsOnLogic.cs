using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Logic
{
    public class GetLightsOnLogic
    {
        public int Handle(List<Instruction> instructions)
        {
            int count = 0;
            foreach (var instruction in instructions)
            {
                if (instruction.Action == LightAction.TurnOn)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
