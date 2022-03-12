using Code.Progress;

namespace Code.Infrastructure.StateMachine
{
    public class BootstrapState : IState
    {
        private readonly IPlayerProgressService _playerProgressService;
        private readonly IGameStateMachine _gameStateMachine;

        public BootstrapState(IPlayerProgressService playerProgressService, IGameStateMachine gameStateMachine)
        {
            _playerProgressService = playerProgressService;
            _gameStateMachine = gameStateMachine;
        }

        public void Enter()
        {
            LoadProgress();
            LoadMenu();
        }

        public void Exit()
        {
        }

        private void LoadProgress()
        {
            _playerProgressService.Load();
        }

        private void LoadMenu()
        {
            // _gameStateMachine.Enter<LoadScene, string>("Menu");
        }
    }

    public class LoadScene : IPayloadState<string>
    {
        public void Enter(string payload)
        {
            throw new System.NotImplementedException();
        }

        public void Enter()
        {
            throw new System.NotImplementedException();
        }

        public void Exit()
        {
            throw new System.NotImplementedException();
        }
    }
}