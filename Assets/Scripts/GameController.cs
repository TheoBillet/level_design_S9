using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public DeathTextController deathTextController;
    public bool isGamePaused = false;
    public CursorManager cursorManager;

    private void Start()
    {
        cursorManager = FindObjectOfType<CursorManager>();
        // Ensure the death text is hidden at the start.
        deathTextController.HideDeathText();
    }

    public void ShowDeathTextAndButtons(string deathMessage)
    {
        deathTextController.ShowDeathText(deathMessage);
    }

    // This function handles the "Restart" button click.
    public void OnRestartButtonClicked()
    {
        if (isGamePaused)
        {
            deathTextController.HideDeathText();
            RestartScene();
        }
    }

    // This function handles the "Quit" button click.
    public void OnQuitButtonClicked()
    {
        if (isGamePaused)
        {
            QuitGame();
        }
    }

    public void RestartScene()
    {
        ToggleGamePause();
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void QuitGame()
    {
        Application.Quit(); // This will quit the game when built as an executable. It won't work in the Unity Editor.
    }

    public void ToggleGamePause()
    {
        isGamePaused = !isGamePaused;

        // If the game is paused, you can also freeze the time:
        if (isGamePaused)
        {
            Time.timeScale = 0f;
            cursorManager.ShowCursor();
        }
        else
        {
            Time.timeScale = 1f; // Unpause and restore normal time scale.
            cursorManager.HideCursor();
        }
    }
}
