namespace ProbablyAFireHazard.Logic.Interfaces
{
    public interface IConvertTo2DArr
    {
        string[,] Convert(IEnumerable<Instruction> instructions);
    }
}
