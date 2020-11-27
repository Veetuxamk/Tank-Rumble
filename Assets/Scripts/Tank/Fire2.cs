using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire2 : MonoBehaviour
{

    public float bulletSpeed = 100;


    public AudioSource audioSource;
    public AudioClip audioClip;
    public GameObject Player;
    
    private void Start()
    {
        Player = GameObject.Find("Tank2");
    }
    void fire()
    {
        GameObject Bullet = ObjectPooler.SharedInstance.GetPooledObject();
        if (Bullet != null)
        {
            Bullet.transform.localPosition = Player.transform.TransformPoint(Vector3.forward * 8);


            Bullet.SetActive(true);
         
            Bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 10000);


        }
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            fire();
            audioSource.clip = audioClip;
            audioSource.Play();
        }

    }
}