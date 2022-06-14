using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateButton : MonoBehaviour
{
    public GameObject gate;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Sphere"))
        {
            gate.SetActive(false);    
        }
        
    }
}
