using Code.Infrastructure.StateMachine;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Core
{
    public class StartGameButton : MonoBehaviour
    {
        public Button StartButton;
        
        private IGameStateMachine _gameStateMachine;

        [Inject]
        private void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        private void OnEnable() =>
            StartButton.onClick.AddListener(StartGame);

        private void OnDisable() =>
            StartButton.onClick.RemoveListener(StartGame);

        private void StartGame() =>
            _gameStateMachine.Enter<StartGameState>();
    }
}
