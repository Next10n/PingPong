using Code.Progress;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Customization
{
    public class ColorPreview : MonoBehaviour
    {
        public Image Preview;
        
        private IPlayerProgressService _progressService;

        [Inject]
        private void Construct(IPlayerProgressService progressService)
        {
            _progressService = progressService;
        }

        private void Start() =>
            ViewColor();

        private void OnEnable() =>
            _progressService.Progress.ColorChanged += ViewColor;

        private void OnDisable() =>
            _progressService.Progress.ColorChanged -= ViewColor;

        private void ViewColor() =>
            Preview.color = _progressService.Progress.Color;
    }
}
