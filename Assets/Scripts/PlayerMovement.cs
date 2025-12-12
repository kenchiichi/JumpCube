using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rigidbody2;

    public float horizontalMovement = 100f;
    public float verticalMovement = 100f;

    public GroundCollider groundCollider;

    void Update()
    {
        //horizontal movement
        if (groundCollider.isOverlapping)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody2.AddForce(new Vector2(0, verticalMovement));
            }
        }
    }

    private void FixedUpdate()
    {
        //vertical movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody2.AddForce(new Vector2(-horizontalMovement * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody2.AddForce(new Vector2(horizontalMovement * Time.deltaTime, 0));
        }

    }
}
