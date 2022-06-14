using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjjectPoolerNew : MonoBehaviour
{
    public GameObject pooledObject;
    public int pooledAmount;

    private List<GameObject> pooledObjects;

    private void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public void GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (pooledObjects[i].activeInHierarchy)
            {
                return ;
            }
        }
    }
}
