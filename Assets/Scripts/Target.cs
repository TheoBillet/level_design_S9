using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Material disabledColor;
    public Material enabledColor;
    public GameObject camToDelete;
    public bool enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void destroy()
    {
        enabled = !enabled;
        if (enabled) {
            GetComponent<MeshRenderer>().material = enabledColor;
        } else
        {
            GetComponent<MeshRenderer>().material = disabledColor;
        }
        camToDelete.SetActive(enabled);
    }
}
