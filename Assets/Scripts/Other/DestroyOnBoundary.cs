using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBoundary : MonoBehaviour
{

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
        // Start is called before the first frame update

    }
}
