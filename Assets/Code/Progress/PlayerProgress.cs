using System;
using UnityEngine;

namespace Code.Progress
{
    [Serializable]
    public class PlayerProgress
    {
        [SerializeField]
        private int _maxScore;
        
        public event Action MaxScoreUpdated;
        public int MaxScore => _maxScore;

        public void SetMaxScore(int currentScore)
        {
            _maxScore = currentScore;
            MaxScoreUpdated?.Invoke();
        }
    }
}