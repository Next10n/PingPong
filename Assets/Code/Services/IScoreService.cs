using System;

namespace Code.Services
{
    public interface IScoreService
    {
        event Action ScoreUpdated;
        int CurrentScore { get; }
        void AddScore();
        void Restart();
    }
}
