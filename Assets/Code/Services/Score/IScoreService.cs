using System;

namespace Code.Services.Score
{
    public interface IScoreService
    {
        event Action ScoreUpdated;
        int CurrentScore { get; }
        void AddScore();
        void Restart();
    }
}
