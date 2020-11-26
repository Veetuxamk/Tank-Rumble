using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject projectile;
    public float bulletSpeed = 100;
    public float attackspeed = 0.5f;
    public float cooldown = 10f;
    public float yValue = 1f;
    public float xValue = 0.2f;

    public AudioSource audioSource;
    public AudioClip audioClip;

    void fire()
    {
        GameObject bullet = ObjectPooler.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
          
            bullet.SetActive(true);
        }

     

        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10000);     
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
    }
}

 
       

