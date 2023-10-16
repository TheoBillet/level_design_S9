using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLaserController : MonoBehaviour
{
    public GameObject laser;
    public bool isPushingButton = false;
    private float toggleCooldown = 0.2f;
    private float lastToggleTime;

    // Update is called once per frame
    void Update()
    {
        if (isPushingButton && Time.time - lastToggleTime > toggleCooldown)
        {
            laser.SetActive(!laser.activeInHierarchy);
            lastToggleTime = Time.time;
            isPushingButton = !isPushingButton;
        }
    }

    void OnMouseDown()
    {
        isPushingButton=!isPushingButton;
    }
}
