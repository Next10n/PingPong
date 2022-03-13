using System;
using Code.Progress;

namespace Code.Services.Score
{
    public class ScoreService : IScoreService
    {
        private readonly IPlayerProgressService _progressService;

        public ScoreService(IPlayerProgressService progressService) =>
            _progressService = progressService;

        public event Action ScoreUpdated;
        public int CurrentScore { get; private set; }
        
        public void AddScore()
        {
            CurrentScore++;
            ScoreUpdated?.Invoke();
            if(_progressService.Progress.MaxScore < CurrentScore)
                _progressService.Progress.SetMaxScore(CurrentScore);
        }

        public void Restart()
        {
            CurrentScore = 0;
            ScoreUpdated?.Invoke();
        }
    }
}