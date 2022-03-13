namespace Code.Core.Balls
{
    public interface IBallFactory
    {
        Ball Ball { get; }
        Ball Create();
    }
}