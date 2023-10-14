using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readAction : MonoBehaviour
{
    public GameObject readPanel;

    // Start is called before the first frame update
 

    private void Start()
    {

        if (readPanel == null)
        {
            Debug.Log("UI read panel n'est pas renseigné");
        }
        readPanel.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (readPanel && readPanel.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                readPanel.SetActive(false);
                this.read();
            }
        }
    }

    private void read()
    {

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            readPanel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            readPanel.SetActive(false);
        }
    }
}
