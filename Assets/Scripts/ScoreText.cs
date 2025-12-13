using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameManager manager;
    public Canvas timeOverlay;

    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (manager.gameOver)
        {
            timeOverlay.enabled = false;
        }
        else
        {
            text.text = (Time.time - startTime).ToString("0.00");
        }
    }
}
