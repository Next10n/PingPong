using Code.Core;

namespace Code.Infrastructure.StateMachine
{
    public interface IBallFactory
    {
        Ball Ball { get; }
        Ball Create();
    }
}