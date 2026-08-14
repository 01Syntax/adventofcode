using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Tests.MemberData
{
    public class LightsOnDataMember
    {
        public IEnumerable<object[]> GetData() =>
        [
            [
                new Instruction
                {
                    Action = LightAction.TurnOn,
                    Start = new Point(0, 0),
                    End = new Point(999, 999)
                },
                new Instruction
                {
                    Action = LightAction.TurnOn,
                    Start = new Point(100, 100),
                    End = new Point(200, 200)
                },
                new Instruction
                {
                    Action = LightAction.TurnOn,
                    Start = new Point(500, 500),
                    End = new Point(750, 750)
                },
                new Instruction
                {
                    Action = LightAction.TurnOff,
                    Start = new Point(250, 250),
                    End = new Point(300, 300)
                },
                3
            ]
        ];
    }
}