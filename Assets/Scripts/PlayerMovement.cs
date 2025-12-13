using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2;

    public float horizontalMovement = 100f;
    public float verticalMovement = 100f;

    public GroundCollider groundCollider;

    private void FixedUpdate()
    {
        //horizontal movement
        if (groundCollider.isOverlapping)
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                rigidbody2.AddForce(new Vector2(0, verticalMovement),ForceMode2D.Impulse);
            }
        }

        //vertical movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2.AddForce(new Vector2(-horizontalMovement, 0));
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2.AddForce(new Vector2(horizontalMovement, 0));
        }

    }
}
