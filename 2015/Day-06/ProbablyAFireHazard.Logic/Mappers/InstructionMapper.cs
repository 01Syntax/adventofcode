using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Mappers
{
    public class InstructionMapper(IActionMapper actionMapper) : IInstructionMapper
    {
        public List<Instruction> Map(string[,] lines)
        {
            var instructions = new List<Instruction>();

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                instructions.Add(new Instruction
                {
                    Action = actionMapper.MapAction(lines[i, 0]),

                    Start = new Point(
                        int.Parse(lines[i, 1]),
                        int.Parse(lines[i, 2])
                    ),

                    End = new Point(
                        int.Parse(lines[i, 3]),
                        int.Parse(lines[i, 4])
                    )
                });
            }

            return instructions;
        }
    }
}