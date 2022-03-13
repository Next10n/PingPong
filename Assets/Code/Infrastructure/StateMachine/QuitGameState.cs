using Code.SaveLoad;

namespace Code.Infrastructure.StateMachine
{
    public class QuitGameState : IState
    {
        private readonly ISaveLoadService _saveLoadService;

        public QuitGameState(ISaveLoadService saveLoadService)
        {
            _saveLoadService = saveLoadService;
        }

        public void Enter() =>
            _saveLoadService.SaveProgress();
    }
}