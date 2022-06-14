using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{
  private void OnCollisionEnter(Collision collision)
  {
    if (collision.collider.CompareTag("Player"))
    {   
     // collision.gameObject.CompareTag("Player");
      Debug.Log("Player Collided");
      CameraCharacter.ballCount -= 5;
      Destroy(gameObject);
    }

    if (collision.collider.CompareTag("Sphere"))
    {
      Destroy(gameObject);
    }
  }

  
}
