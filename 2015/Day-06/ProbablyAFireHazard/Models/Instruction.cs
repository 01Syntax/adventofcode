namespace ProbablyAFireHazard.Models
{
    public class Instruction
    {
        public string Action { get; set; } = string.Empty;
        public Point Start { get; set; } = new Point();
        public Point End { get; set; } = new Point();
    }
}
