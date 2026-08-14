using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Mappers
{
    public class InstructionMapper
    {
        public List<Instruction> Map(string[,] lines)
        {
            var instructions = new List<Instruction>();

            for (int i = 0; i < lines.GetLength(0); i++)
            {
                for (int j = 0; j < lines.GetLength(1); j++)
                {
                    instructions.Add(new Instruction
                    {
                        Action = (LightAction)Enum.Parse(typeof(LightAction), lines[i, j]),
                        Start = new Point(i, j),
                        End = new Point(i, j)
                    });
                }
            }
            return instructions;
        }
    }
}
