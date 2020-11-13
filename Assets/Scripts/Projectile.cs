using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Projectile : MonoBehaviour
{
    public static Projectile SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject ObjectToPool;
    public int ammountToPool;



    void Awake()
    {
    SharedInstance = this;
    }

    private void Start()
    {
    pooledObjects = new List<GameObject>();
   
      
         for (int i = 0; i < ammountToPool; i++)
          {
            GameObject obj = (GameObject)Instantiate(ObjectToPool);
            obj.SetActive(false);
            pooledObjects.Add(obj);
          }
    }
    public GameObject GetPooledObject()
    {
        for(int i = 0;i<pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}