using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRotation : MonoBehaviour
{

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   

    private void Awake()
    {
        transform.Rotate(90f, -90f, -45f, Space.Self);
    }
    
    void Update()
    {
      
    }
}
