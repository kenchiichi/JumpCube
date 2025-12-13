using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameManager manager;

    public TextMeshProUGUI winScoreText;
    public Canvas winScreen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !manager.gameOver)
        {
            manager.GameWin(winScoreText, winScreen);
        }
    }
}
