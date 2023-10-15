using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watch : MonoBehaviour
{
    public GameObject timer;
    // Start is called before the first frame update
    void Start()
    {
        if (timer == null)
        {
            Debug.Log("Timer UI non mis sur le joueur");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            this.showTime(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            this.showTime(false);
        }
    }
    public void showTime (bool val)
    {
        timer.SetActive(val);
    }
}
