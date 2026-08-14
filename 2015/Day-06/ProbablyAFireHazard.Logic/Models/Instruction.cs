namespace ProbablyAFireHazard.Logic.Models
{
    public record Instruction
    {
        public LightAction Action { get; set; }
        public Point Start { get; set; } = new(0, 0);
        public Point End { get; set; } = new(999, 999);
    }
}