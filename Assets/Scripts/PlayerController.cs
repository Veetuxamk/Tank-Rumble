using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 velocity;
    private float turnrate = 1;
    private float tankSpeed = 5.0f;

    private Projectile gameManager;
    private ObjectPooler BulletPooler;



    void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        ObjectPooler = GetComponent<ObjectPooler>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * tankSpeed);
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}*/
