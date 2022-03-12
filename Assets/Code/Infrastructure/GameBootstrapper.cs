using Code.Infrastructure.StateMachine;
using UnityEngine;

namespace Code.Infrastructure
{
    public class GameBootstrapper : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        private void Awake()
        {
            _gameStateMachine = new GameStateMachine();
            _gameStateMachine.Enter<StartGameState>();
        }
    }
}