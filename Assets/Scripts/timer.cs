using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timer : MonoBehaviour
{
     
    public float time;
    public float hour = 23;
    public float minutes = 0;

    public TMP_Text textUI;

    // Start is called before the first frame update
    void Start()
    {
        if (textUI == null)
        {
            Debug.Log("text UI non mi sur timer UI");
        }
        showTime();
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5)
        {
            minutes++;
            if (minutes >= 60)
            {
                minutes = 0;
                hour = (hour + 1) % 24;
            }
            time = 0; 
            showTime();
        }
    }

    private void showTime ()
    {
        textUI.text = hour + ":" + (minutes < 10 ? "0" : "") + minutes;
    }
}
