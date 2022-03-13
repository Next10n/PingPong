using Code.Infrastructure.StateMachine;
using UnityEngine;
using Zenject;

namespace Code.Infrastructure
{
    public class EndGameHandler : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        private void OnDestroy()
        {
            _gameStateMachine.Enter<QuitGameState>();
        }
    }
}
