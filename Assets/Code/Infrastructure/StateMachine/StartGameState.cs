using Code.Core.Balls;

namespace Code.Infrastructure.StateMachine
{
    public class StartGameState : IState
    {
        private readonly IGameFactory _gameFactory;

        public StartGameState(IGameFactory gameFactory)
        {
            _gameFactory = gameFactory;
        }
        
        public void Enter()
        {
            CreateHud();
            SpawnBall();
            ForceBall();
        }

        private void CreateHud() =>
            _gameFactory.CreateHud();

        private void SpawnBall() =>
            _gameFactory.CreateBall();

        private void ForceBall() =>
            _gameFactory.Ball.ForceRandom();
    }
}