using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Tests.MemberData
{
    public class OnInstructionsMember
    {
        public static IEnumerable<object[]> GetOnInstructions() =>
        [
            [
                new List<Instruction>
                {
                    new()
                    {
                        Action = LightAction.TurnOn,
                        Start = new Point(887, 9),
                        End = new Point(959, 629)
                    },

                    new()
                    {
                        Action = LightAction.TurnOn,
                        Start = new Point(454, 398),
                        End = new Point(844, 448)
                    },

                    new()
                    {
                        Action = LightAction.TurnOff,
                        Start = new Point(539, 243),
                        End = new Point(559, 965)
                    },

                    new()
                    {
                        Action = LightAction.TurnOff,
                        Start = new Point(370, 819),
                        End = new Point(676, 868)
                    },
                },
                2
            ],
        ];
    }
}
