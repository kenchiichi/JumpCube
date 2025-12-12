using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Collision2D collision2D;
    public bool GameOver = false;
    public TextMeshProUGUI text;
    public Canvas canvas;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            movement.enabled = false;
            canvas.enabled = true;
            GameOver = true;
            text.text = "You Died";
        }
    }
}
