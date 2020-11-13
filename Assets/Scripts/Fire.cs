using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;


    void Update()
    {
       if (Input.GetKeyDown("Space"))
       {
            GameObject APR_Round = Projectile.SharedInstance.GetPooledObject();
          /*  if (APR_Round != null)
            {
                APR_Round.transform.position = turret.transform.position;
                APR_Round.transform.position = turret.transform.rotation;
                APR_Round.SetActive(true);
            }*/
       }
    }
}

 
       

