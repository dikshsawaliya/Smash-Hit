using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public AudioSource glassBreakAudio;

    // Start is called before the first frame update
    void Start()
    {
        glassBreakAudio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Glass")
        {
            glassBreakAudio.Play();
        }

        
    }
}
