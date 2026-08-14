using ProbablyAFireHazard.Logic.Interfaces;
using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Helpers
{
    public class ConvertTo2DArr : IConvertTo2DArr
    {
        public string[,] Convert(IEnumerable<Instruction> instructions)
        {
            var list = instructions.ToList();
            var arr = new string[list.Count, 5];

            for (int i = 0; i < list.Count; i++)
            {
                var instruction = list[i];
                arr[i, 0] = instruction.Action switch
                {
                    LightAction.TurnOn => "on",
                    LightAction.TurnOff => "off",
                    LightAction.Toggle => "toggle",
                    _ => throw new ArgumentOutOfRangeException(nameof(instruction.Action))
                };
                arr[i, 1] = instruction.Start.X.ToString();
                arr[i, 2] = instruction.Start.Y.ToString();
                arr[i, 3] = instruction.End.X.ToString();
                arr[i, 4] = instruction.End.Y.ToString();
            }
            return arr;
        }
    }
}
