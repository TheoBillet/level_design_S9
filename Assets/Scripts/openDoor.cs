using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private GameObject openPanel = null;
    private bool isOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        openPanel = GameObject.FindWithTag("openPanel");

        if (openPanel == null)
        {
            Debug.Log("UI openPanel n'est pas renseigné");
        }

        openPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (openPanel && openPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                openPanel.SetActive(false);
                this.open();
            }
        }
    }

    private void open ()
    {
        transform.Rotate(0, 0, 90.0f);
        isOpen = true;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpen)
        {
            openPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            openPanel.SetActive(false);
        }
    }
}
