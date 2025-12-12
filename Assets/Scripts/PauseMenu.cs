using TMPro;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Canvas canvas;
    public PlayerCollision collision;
    public PlayerMovement movement;
    public TextMeshProUGUI text;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canvas.enabled == false)
        {
            if (!collision.GameOver)
            {
                movement.enabled = false;
                text.text = "Paused";
            }
            else
            {
                text.text = "You Died";
            }
            canvas.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && canvas.enabled == true)
        {
            if (!collision.GameOver)
            {
                movement.enabled = true;
                text.text = "Paused";
            }
            else
            {
                text.text = "You Died";
            }
                canvas.enabled = false;
        }
    }
}
