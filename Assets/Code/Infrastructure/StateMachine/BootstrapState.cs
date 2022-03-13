using Code.Progress;
using Code.SaveLoad;

namespace Code.Infrastructure.StateMachine
{
    public class BootstrapState : IState
    {
        private const string MenuSceneName = "Menu";
        
        private readonly IPlayerProgressService _progressService;
        private readonly ISaveLoadService _saveLoadService;
        private readonly ISceneLoader _sceneLoader;

        public BootstrapState(IPlayerProgressService progressService, ISaveLoadService saveLoadService, ISceneLoader sceneLoader)
        {
            _progressService = progressService;
            _saveLoadService = saveLoadService;
            _sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            LoadOrCreateProgress();
            LoadMenu();
        }

        private void LoadOrCreateProgress()
        {
            _saveLoadService.LoadProgress();
            if(_progressService.Progress == null)
                _progressService.Create();
        }

        private void LoadMenu() =>
            _sceneLoader.Load(MenuSceneName);
    }
}