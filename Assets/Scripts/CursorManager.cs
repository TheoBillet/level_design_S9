using UnityEngine;

public class CursorManager : MonoBehaviour
{
    private bool isCursorHidden = false;

    void Start()
    {
        // Cacher le curseur au démarrage du jeu.
        HideCursor();
    }

    void Update() {}

    public void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isCursorHidden = true;
    }

    public void ShowCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        isCursorHidden = false;
    }
}
