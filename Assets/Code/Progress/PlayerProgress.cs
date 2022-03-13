using System;
using UnityEngine;

namespace Code.Progress
{
    [Serializable]
    public class PlayerProgress
    {
        [SerializeField]
        private int _maxScore;

        [SerializeField]
        private Color _color;

        public int MaxScore => _maxScore;
        public Color Color => _color;
        
        public event Action MaxScoreUpdated;
        public event Action ColorChanged;

        public PlayerProgress() =>
            _color = new Color(1f, 1f, 1f);

        public void SetMaxScore(int currentScore)
        {
            _maxScore = currentScore;
            MaxScoreUpdated?.Invoke();
        }

        public void SetColor(Color color)
        {
            _color = color;
            ColorChanged?.Invoke();
        }
    }
}