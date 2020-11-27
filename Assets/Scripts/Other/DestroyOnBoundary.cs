﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnBoundary : MonoBehaviour
{
    public class DestroyOutOfBounds : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }
        private float topBound = 100;
        private float lowerBound = -100;
        // Update is called once per frame
        void Update()
        {
            if (transform.position.z > topBound)
            {
                Destroy(gameObject);
            }
           
        }
    }
}
