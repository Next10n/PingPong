using Code.Progress;
using Code.SaveLoad;
using UnityEngine;

namespace Code.Infrastructure.StateMachine
{
    public class BootstrapState : IState
    {
        private readonly IPlayerProgressService _progressService;
        private readonly ISaveLoadService _saveLoadService;
        private readonly IGameStateMachine _gameStateMachine;

        public BootstrapState(IPlayerProgressService progressService, IGameStateMachine gameStateMachine, ISaveLoadService saveLoadService)
        {
            _progressService = progressService;
            _gameStateMachine = gameStateMachine;
            _saveLoadService = saveLoadService;
        }

        public void Enter()
        {
            LoadOrCreateProgress();
            StartGame();
        }

        private void LoadOrCreateProgress()
        {
            _saveLoadService.LoadProgress();
            if(_progressService.Progress == null)
                _progressService.Create();
        }

        private void StartGame() =>
            _gameStateMachine.Enter<StartGameState>();
    }
}