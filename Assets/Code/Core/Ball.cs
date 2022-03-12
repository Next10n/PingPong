using UnityEngine;

namespace Code.Core
{
    public class Ball : MonoBehaviour
    {
        public Rigidbody2D Rigidbody;
        private float _force = 10f;

        public void ForceRandom()
        {
            Vector2 direction = new Vector2(Random.Range(-0.25f, 0.25f), Random.Range(-1f, 1f));
            Rigidbody.AddForce(direction.normalized * _force, ForceMode2D.Impulse);
        }

        public void Respawn()
        {
            Rigidbody.velocity = Vector2.zero;
            transform.position = Vector3.zero;
        }

    }
}