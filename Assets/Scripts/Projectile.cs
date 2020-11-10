using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    // Use this for initialization

    public float speed;

    bool bulletDirection;


    void Start()
    {
        
    }


    void OnEnable()
    {
        bulletDirection = SimpleTankMovement.facingRight;
    }


    // Update is called once per frame
    void Update()
    {


        if (bulletDirection == false)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);


        }
        else
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);

        }

        //transform.Translate(-speed * Time.deltaTime, 0, 0);





    }
    void Fire()
    {

        GameObject obj = ObjectPooler.current.GetPooledObject();
        if (obj == null) return;

        // Resets the Position and Rotation of the projectiles when they become active again
        obj.transform.position = bulletOrigin.position;
        obj.transform.rotation = bulletOrigin.rotation;

        obj.SetActive(true);
    }

}