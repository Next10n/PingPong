using Code.Services;
using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class RespawnBallState : IState
    {
        private readonly IBallFactory _ballFactory;
        private readonly IScoreService _scoreService;

        public RespawnBallState(IBallFactory ballFactory, IScoreService scoreService)
        {
            _ballFactory = ballFactory;
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
            _ballFactory.Ball.Respawn();

        private void InitializeBall() =>
            _ballFactory.Ball.Initialize(Random.Range(0.1f, 0.4f), Random.Range(5f, 10f));

        private void ForceBall() =>
            _ballFactory.Ball.ForceRandom();

    }
}