using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerMovement movement;
    public bool gameOver = false;

    private float startTime;
    private void Start()
    {
        startTime = Time.time;
    }

    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame(Canvas pauseScreen)
    {
        movement.enabled = false;
        pauseScreen.enabled = true;
    }
    public void PlayGame(Canvas unPauseScreen)
    {
        movement.enabled = true;
        unPauseScreen.enabled = false;

    }
    public void GameOver(TextMeshProUGUI gameOverScoreText, Canvas gameOverScreen)
    {
        if (gameOver)
        {
            movement.enabled = false;
            gameOverScoreText.text = (Time.time - startTime).ToString("0.00");
            gameOverScreen.enabled = true;
        }
    }
    public void GameWin(TextMeshProUGUI winScoreText, Canvas winScreen)
    {
        movement.rigidbody2.angularVelocity = 0;
        movement.rigidbody2.linearVelocity = new Vector2(0, 0);
        gameOver = true;
        movement.enabled = false;
        winScoreText.text = (Time.time - startTime).ToString("0.00");
        winScreen.enabled = true;
    }
}
