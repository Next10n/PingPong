namespace Code.Infrastructure.StateMachine
{
    public class RespawnBallState : IState
    {
        private readonly IBallFactory _ballFactory;

        public RespawnBallState(IBallFactory ballFactory)
        {
            _ballFactory = ballFactory;
        }

        public void Enter()
        {
            RespawnBall();
            ForceBall();
        }

        private void RespawnBall() =>
            _ballFactory.Ball.Respawn();

        private void ForceBall() =>
            _ballFactory.Ball.ForceRandom();


        public void Exit()
        {
        }
    }
}