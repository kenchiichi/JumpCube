using TMPro;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameManager manager;

    public Canvas pauseScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.enabled == false)
        {
            manager.PauseGame(pauseScreen); 
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && pauseScreen.enabled == true)
        {
            manager.PlayGame(pauseScreen);
        }
    }
}
