using ProbablyAFireHazard.Logic.Models;

namespace ProbablyAFireHazard.Logic.Tests.MemberData
{
    public class Arr2DDataMember
    {
        public static IEnumerable<object[]> Get2D() =>
        [
            [
                new List<Instruction>
                {
                    new() { Action = LightAction.TurnOn, Start = new Point(887, 9), End = new Point(959, 629) },
                    new() { Action = LightAction.TurnOn, Start = new Point(454, 398), End = new Point(844, 448) },
                    new() { Action = LightAction.TurnOff, Start = new Point(539, 243), End = new Point(559, 965) },
                    new() { Action = LightAction.TurnOff, Start = new Point(370, 819), End = new Point(676, 868) },
                    new() { Action = LightAction.Toggle, Start = new Point(0, 0), End = new Point(999, 0) },
                    new() { Action = LightAction.Toggle, Start = new Point(20, 0), End = new Point(990, 0) },
                },
                new[,]
                {
                    { "on", "887", "9", "959", "629" },
                    { "on", "454", "398", "844", "448" },
                    { "off", "539", "243", "559", "965" },
                    { "off", "370", "819", "676", "868" },
                    { "toggle", "0", "0", "999", "0" },
                    { "toggle", "20", "0", "990", "0" }
                }
            ],
        ];
    }
}