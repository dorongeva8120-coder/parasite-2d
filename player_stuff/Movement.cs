using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float speed = 5f;
    public float jumpforce = 2f;
    float horizontal_movemnt;

    bool grounded = false;
    public void Move(InputAction.CallbackContext cbc)
    {
        horizontal_movemnt = cbc.ReadValue<Vector2>().x;
    }
    public void Jump(InputAction.CallbackContext cbc)
    {
        if (grounded)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
        }
    }
    private void Update()
    {
        rb.linearVelocity = new Vector2(horizontal_movemnt * speed, rb.linearVelocity.y);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
