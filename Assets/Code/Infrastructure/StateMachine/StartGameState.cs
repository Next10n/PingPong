using Code.Core;
using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class StartGameState : IState
    {
        private readonly IAssetProvider _assetProvider;

        public StartGameState(IAssetProvider assetProvider) =>
            _assetProvider = assetProvider;


        public void Enter()
        {
            Ball ball = SpawnBall();
            ForceBall(ball);
        }
        
        public void Exit()
        {
        }

        private Ball SpawnBall()
        {
            Ball ball = _assetProvider.Load<Ball>("Ball");
            return Object.Instantiate(ball);
        }

        private void ForceBall(Ball ball)
        {
            ball.ForceRandom();
        }
    }
}