using Code.Progress;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Services
{
    public class MaxScoreView : MonoBehaviour
    {
        public Text MaxScore;
        
        private IPlayerProgressService _progressService;

        [Inject]
        private void Construct(IPlayerProgressService playerProgressService)
        {
            _progressService = playerProgressService;
        }

        private void Start() =>
            ViewScore();

        private void OnEnable() =>
            _progressService.Progress.MaxScoreUpdated += ViewScore;

        private void OnDisable() =>
            _progressService.Progress.MaxScoreUpdated -= ViewScore;

        private void ViewScore() =>
            MaxScore.text = _progressService.Progress.MaxScore.ToString();
    }
}
