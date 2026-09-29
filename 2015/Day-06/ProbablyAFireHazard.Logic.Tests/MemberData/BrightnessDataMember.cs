using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Tests.MemberData
{
    public class BrightnessDataMember
    {
        public static IEnumerable<object[]> GetData() =>
        [
            [
                new List<Instruction>
                {
                    new()
                    {
                        Action = LightAction.TurnOn,
                        Start = new Point(0, 0),
                        End = new Point(0, 0)
                    }
                },
                1
            ],
            [
                new List<Instruction>
                {
                    new()
                    {
                        Action = LightAction.Toggle,
                        Start = new Point(0, 0),
                        End = new Point(999, 999)
                    }
                },
                2000000
            ],
            [
                new List<Instruction>
                {
                    new()
                    {
                        Action = LightAction.TurnOn,
                        Start = new Point(0, 0),
                        End = new Point(1, 0)
                    },

                    new()
                    {
                        Action = LightAction.TurnOff,
                        Start = new Point(0, 0),
                        End = new Point(0, 0)
                    },

                    new()
                    {
                        Action = LightAction.TurnOff,
                        Start = new Point(0, 0),
                        End = new Point(0, 0)
                    }
                },
                1
            ]
        ];
    }
}
