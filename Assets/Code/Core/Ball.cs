using UnityEngine;

namespace Code.Core
{
    public class Ball : MonoBehaviour
    {
        public SpriteRenderer SpriteRenderer;
        public Rigidbody2D Rigidbody;
        private float _moveForce = 10f;

        public void Initialize(float scale, float moveForce)
        {
            transform.localScale = new Vector3(scale, scale, scale);
            _moveForce = moveForce;
        }

        public void SetColor(Color color) =>
            SpriteRenderer.color = color;

        public void ForceRandom()
        {
            Vector2 direction = new Vector2(Random.Range(-0.25f, 0.25f), Random.Range(-1f, 1f));
            Rigidbody.AddForce(direction.normalized * _moveForce, ForceMode2D.Impulse);
        }

        public void Respawn()
        {
            Rigidbody.velocity = Vector2.zero;
            transform.position = Vector3.zero;
        }
    }
}