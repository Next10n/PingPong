using Code.Core;
using Code.Progress;

namespace Code.Infrastructure.StateMachine
{
    public class StartGameState : IState
    {
        private const string GameSceneName = "Game";
        
        private readonly IGameFactory _gameFactory;
        private readonly ISceneLoader _sceneLoader;
        private readonly IPlayerProgressService _progressService;

        public StartGameState(IGameFactory gameFactory, ISceneLoader sceneLoader, IPlayerProgressService progressService)
        {
            _gameFactory = gameFactory;
            _sceneLoader = sceneLoader;
            _progressService = progressService;
        }
        
        public void Enter() =>
            LoadGameScene();

        private void LoadGameScene() =>
            _sceneLoader.Load(GameSceneName, OnLoad);

        private void OnLoad()
        {
            CreateHud();
            SpawnBall();
            ForceBall();
        }

        private void CreateHud() =>
            _gameFactory.CreateHud();

        private void SpawnBall()
        {
            Ball ball = _gameFactory.CreateBall();
            ball.Initialize(0.2f, 10f);
            ball.SetColor(_progressService.Progress.Color);
        }

        private void ForceBall() =>
            _gameFactory.Ball.ForceRandom();
    }
}