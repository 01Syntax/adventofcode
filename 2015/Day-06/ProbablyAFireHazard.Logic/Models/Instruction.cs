namespace ProbablyAFireHazard.Logic.Models
{
    public class Instruction
    {
        public LightAction Action { get; set; } = new LightAction();
        public Point Start { get; set; } = new Point(0, 0);
        public Point End { get; set; } = new Point(999, 999);
    }
}
