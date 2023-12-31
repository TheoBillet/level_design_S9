using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private bool isShooting = false;
    public GameObject laser;
    public GameObject lightIndicator;
    public Material lightOffMaterial;
    public Material lightOnMaterial;
    private float lastShoot = 0;
    private float rateShoot = 0.5f;
    private float timeShoot = 0.20f;
    public GameObject gun;
    public Camera fpsCam;
    public float range = 100f;

    // Start is called before the first frame update
    void Start()
    {
        if (laser is null)
        {
            Debug.Log("Laser gun is null");
        }
        if (lightIndicator is null)
        {
            Debug.Log("lightIndicator gun is null");
        }
        if (lightOffMaterial is null)
        {
            Debug.Log("light material is null");
        }
        if (lightOnMaterial is null)
        {
            Debug.Log("light material is null");
        }
        if (gun is null)
        {
            Debug.Log("fps cam null dans player shoot");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartShoot();
        } else
        {
            StopShooting();
        }
    }

    public void StartShoot()
    {
        if (Time.time < lastShoot + rateShoot)
        {
            return;
        }
        isShooting = true;
        laser.SetActive(true);
        lastShoot = Time.time;
        lightIndicator.GetComponent<MeshRenderer>().material = lightOnMaterial;



        shoot();
    }


    public void shoot()
    {
        RaycastHit[] hits;
        hits = Physics.RaycastAll(gun.transform.position, fpsCam.transform.forward, range);

        for (int i = 0; i < hits.Length; i++)
        {
            RaycastHit hit = hits[i];
            Target target = hit.transform.GetComponent<Target>();
            //Debug.DrawRay(gun.transform.position, fpsCam.transform.forward * range, Color.green, abilityTime);
            if (target != null)
            {
                target.destroy();
            }
        }
    }

    public void StopShooting ()
    {
        if (Time.time < timeShoot + lastShoot)
        {
            return;
        }
        isShooting = false;
        laser.SetActive(false);
        if (Time.time < rateShoot + lastShoot)
        {
            return;
        }
        lightIndicator.GetComponent<MeshRenderer>().material = lightOffMaterial;
    }
}
