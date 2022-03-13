using Code.Core;
using Code.Core.Balls;
using UnityEngine;
using Zenject;

namespace Code.Services
{
    public class ScoreTrigger : MonoBehaviour
    {
        private IScoreService _scoreService;

        [Inject]
        private void Construct(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.TryGetComponent(out Ball ball))
                _scoreService.AddScore();
        }
    }
}
