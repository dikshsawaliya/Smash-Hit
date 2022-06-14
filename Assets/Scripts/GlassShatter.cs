using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GlassShatter : MonoBehaviour {
    public GameObject[] shatteredObject;
    public int destructionReward = 2;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Sphere"))
        {
            //picks a random gameobject in the array
            int objectIndex = Random.RandomRange(0, shatteredObject.Length);
            Instantiate(shatteredObject[objectIndex], transform.position, shatteredObject[objectIndex].transform.rotation);
            //By using a static variable, we can access the variable directly
            PointAndShoot.ballCount += destructionReward;
            Destroy(gameObject);
        }    }
}