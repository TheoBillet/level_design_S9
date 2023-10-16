using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;
    public timer timer;
    private bool playerAround = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!winPanel)
        {
            Debug.Log("win panel pas mi dans victory aera map");
        }
        if (!losePanel)
        {
            Debug.Log("lose panel pas mi dans victory aera map");
        }
        if (!timer)
        {
            Debug.Log("timer script du panel pas mi dans victory aera map");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerAround = true;
            if (timer.minutes >= 45 || timer.hour < 23)
            {
                losePanel.SetActive(true);
            } else
            {
                winPanel.SetActive(true);
            }
            // SceneManager.LoadScene(3);
        }
    }

}
