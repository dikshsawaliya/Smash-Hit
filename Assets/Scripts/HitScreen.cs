using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitScreen : MonoBehaviour
{

    public GameObject hitScreen;

    // Update is called once per frame
    void Update()
    {


        if (hitScreen != null)
        {
            if (hitScreen.GetComponent<Image>().color.a >0)
            {
                var color = hitScreen.GetComponent<Image>().color;
                color.a -= 0.01f;
                hitScreen.GetComponent<Image>().color = color;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Glass") ||collision.collider.CompareTag("Door") )
        {
            gotHurt();
        }

    }

    public void gotHurt()
    {
        var colour = hitScreen.GetComponent<Image>().color;
        colour.a = 0.8f;

        hitScreen.GetComponent<Image>().color = colour;
    }
}
