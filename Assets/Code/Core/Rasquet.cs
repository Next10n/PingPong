using UnityEngine;
using UnityEngine.InputSystem;

namespace Code.Core
{
    public class Rasquet : MonoBehaviour
    {
        public Rigidbody2D Rigidbody;
        public float MoveSpeed;

        public void Move(InputAction.CallbackContext context) =>
            Rigidbody.velocity = new Vector2(context.ReadValue<Vector2>().x * MoveSpeed, 0);
    }
}