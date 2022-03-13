using Code.Data;
using Code.Progress;
using UnityEngine;

namespace Code.SaveLoad
{
    public class SaveLoadService : ISaveLoadService
    {
        private readonly IPlayerProgressService _progressService;

        public SaveLoadService(IPlayerProgressService progressService)
        {
            _progressService = progressService;
        }

        private const string ProgressKey = "Progress";

        
        public void SaveProgress() =>
            PlayerPrefs.SetString(ProgressKey, _progressService.Progress.ToJson());

        public void LoadProgress() =>
            _progressService.Load(PlayerPrefs.GetString(ProgressKey)?.ToDeserialized<PlayerProgress>());
    }
}