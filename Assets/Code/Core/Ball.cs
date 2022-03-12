using UnityEngine;

namespace Code.Core
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D Rigidbody;

        public void ForceRandom()
        {
            Rigidbody.AddForce(Random.insideUnitCircle.normalized * 5f, ForceMode2D.Impulse);
        }
        
        
    }
}