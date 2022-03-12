namespace Code.Infrastructure.StateMachine
{
    public interface IPayloadState<in TPayload> : IState
    {
        void Enter(TPayload payload);
    }
}