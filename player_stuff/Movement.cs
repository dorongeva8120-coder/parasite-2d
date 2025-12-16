using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 5f;
    public float jumpforce = 2f;
    Vector2 horizontal_movemnt;

    public void Move(InputAction.CallbackContext cbc)
    {
        horizontal_movemnt = cbc.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = horizontal_movemnt * speed;
    }

}
