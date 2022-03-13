using Code.Core;
using Code.Services;
using Code.Services.Score;
using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class RespawnBallState : IState
    {
        private readonly IGameFactory _gameFactory;
        private readonly IScoreService _scoreService;

        public RespawnBallState(IGameFactory gameFactory, IScoreService scoreService)
        {
            _gameFactory = gameFactory;
            _scoreService = scoreService;
        }

        public void Enter()
        {
            RestartScore();
            RespawnBall();
            InitializeBall();
            ForceBall();
        }

        private void RestartScore() =>
            _scoreService.Restart();

        private void RespawnBall() =>
            _gameFactory.Ball.Respawn();

        private void InitializeBall() =>
            _gameFactory.Ball.Initialize(Random.Range(0.1f, 0.4f), Random.Range(5f, 10f));

        private void ForceBall() =>
            _gameFactory.Ball.ForceRandom();

    }
}