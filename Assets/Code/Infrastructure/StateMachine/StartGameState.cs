using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class StartGameState : IState
    {
        private readonly IBallFactory _ballFactory;

        public StartGameState(IBallFactory ballFactory) =>
            _ballFactory = ballFactory;


        public void Enter()
        {
            SpawnBall();
            ForceBall();
        }

        public void Exit()
        {
        }

        private void SpawnBall() =>
            _ballFactory.Create();

        private void ForceBall() =>
            _ballFactory.Ball.ForceRandom();
    }
}