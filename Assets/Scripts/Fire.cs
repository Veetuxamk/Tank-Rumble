using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public float bulletSpeed;
    public float attackspeed = 0.5f;
    public float cooldown;
    public float yValue = 1f;
    public float xValue = 0.2f;

    public AudioSource audioSource;
    public AudioClip audioClip;

    public GameObject InvisObj;

    void fire()
    {


        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;

        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10);

        
    }
    

    void Update()
    {
        if (Time.time >= cooldown)
        {


            if (Input.GetKeyDown(KeyCode.Space))
            {
                fire();
                audioSource.clip = audioClip;
                audioSource.Play();
            }
        }
        float x = InvisObj.transform.rotation;
    }

   

}

 
       

