using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletingLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
     Destroy(gameObject);
        
    }
}
