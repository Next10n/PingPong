using System;

namespace Code.Progress
{
    [Serializable]
    public class PlayerProgress
    {
        public event Action MaxScoreUpdated;
        public int MaxScore { get; private set; }

        public void SetMaxScore(int currentScore)
        {
            MaxScore = currentScore;
            MaxScoreUpdated?.Invoke();
        }
    }
}