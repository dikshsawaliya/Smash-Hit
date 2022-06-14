using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cone : MonoBehaviour
{
    public int destructionReward = 3;

 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Sphere"))
        {
            CameraCharacter.ballCount += destructionReward;
            Destroy(gameObject);
        }

   
    }
}
