using UnityEngine;

namespace Code.Core
{
    public class Rasquet : MonoBehaviour
    {
        public Rigidbody2D Rigidbody;
        
        private IRasquetControlService _rasquetControlService;

        private void Construct(IRasquetControlService rasquetControlService)
        {
            _rasquetControlService = rasquetControlService;
        }
        
        private void Awake() =>
            _rasquetControlService.Register(this);

        public void Move(float value) =>
            Rigidbody.velocity = new Vector2(value, 0);
    }
}