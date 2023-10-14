using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DeathTextController : MonoBehaviour
{
    public TextMeshProUGUI deathText;
    public GameObject restartButtonObject;
    public GameObject quitButtonObject;

    private float previousTimeScale;
    private GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        HideDeathText();
    }

    public void ShowDeathText(string deathMessage)
    {
        gameController.ToggleGamePause();

        deathText.text = deathMessage;
        deathText.enabled = true;

        restartButtonObject.SetActive(true);
        quitButtonObject.SetActive(true);
    }

    public void HideDeathText()
    {
        // Resume the game by restoring the previous time scale.
        previousTimeScale = Time.timeScale;

        deathText.enabled = false;
        restartButtonObject.SetActive(false);
        quitButtonObject.SetActive(false);
    }

    public void RestartButtonClicked()
    {
        gameController.OnRestartButtonClicked();
    }

    public void QuitButtonClicked()
    {
        gameController.OnQuitButtonClicked();
    }
}
