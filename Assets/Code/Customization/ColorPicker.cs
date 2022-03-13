using Code.Progress;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Customization
{
    public class ColorPicker : MonoBehaviour
    {
        public Slider SliderR;
        public Slider SliderG;
        public Slider SliderB;
        
        private IPlayerProgressService _playerProgress;

        [Inject]
        private void Construct(IPlayerProgressService playerProgressService)
        {
            _playerProgress = playerProgressService;
        }

        private void Start()
        {
            SliderR.value = _playerProgress.Progress.Color.r;
            SliderG.value = _playerProgress.Progress.Color.g;
            SliderB.value = _playerProgress.Progress.Color.b;
        }

        private void OnEnable()
        {
            SliderR.onValueChanged.AddListener(ChangeColor);
            SliderG.onValueChanged.AddListener(ChangeColor);
            SliderB.onValueChanged.AddListener(ChangeColor);
        }

        private void OnDisable()
        {
            SliderR.onValueChanged.RemoveListener(ChangeColor);
            SliderG.onValueChanged.RemoveListener(ChangeColor);
            SliderB.onValueChanged.RemoveListener(ChangeColor);
        }

        private void ChangeColor(float value) =>
            _playerProgress.Progress.SetColor(new Color(SliderR.value, SliderG.value, SliderB.value));
    }
}