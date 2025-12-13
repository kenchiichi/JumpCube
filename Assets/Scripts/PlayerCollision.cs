using TMPro;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager manager;

    public TextMeshProUGUI gameOverScoreText;
    public Canvas gameOverScreen;
    public PlayerMovement movement;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground") && !manager.gameOver)
        {
            manager.gameOver = true;
            manager.GameOver(gameOverScoreText, gameOverScreen);
        }
    }
}
