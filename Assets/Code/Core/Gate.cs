using Code.Infrastructure.StateMachine;
using UnityEngine;
using Zenject;

namespace Code.Core
{
    public class Gate : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            _gameStateMachine.Enter<RespawnBallState>();
        }
    }
}
