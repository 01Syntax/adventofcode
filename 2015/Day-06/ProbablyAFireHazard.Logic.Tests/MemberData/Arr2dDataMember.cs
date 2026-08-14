namespace ProbablyAFireHazard.Logic.Tests.MemberData
{
    public class InstructionsDataMember
    {
        public static IEnumerable<object[]> GetInstructions() =>
        [
            [
                new List<string>
                {
                    "turn on 887,9 through 959,629",
                    "turn on 454,398 through 844,448",
                    "turn off 539,243 through 559,965",
                    "turn off 370,819 through 676,868",
                    "toggle 0,0 through 999,0",
                    "toggle 20,0 through 990,0"
                },
                new string[,]
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