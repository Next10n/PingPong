using System;
using Code.Infrastructure.StateMachine;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Services
{
    public class ScoreCounter : MonoBehaviour
    {
        public Text Score;
        
        private IScoreService _scoreService;

        [Inject]
        private void Construct(IScoreService scoreService)
        {
            _scoreService = scoreService;
        }

        private void Start() =>
            ViewScore();

        private void OnEnable() =>
            _scoreService.ScoreUpdated += ViewScore;

        private void OnDisable() =>
            _scoreService.ScoreUpdated -= ViewScore;

        private void ViewScore() =>
            Score.text = _scoreService.CurrentScore.ToString();
    }
}
