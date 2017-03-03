using UnityEngine;
using System.Collections;

public class CheckerDetection : MonoBehaviour {

    private float zPos = 0, xPos = 0;


    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnTriggerExit(Collider other)
    {
        if (zPos <= 0 && xPos <= 0)
        {
            other.GetComponent<Renderer>().material.color = Color.white;
        }
        else
            other.GetComponent<Renderer>().material.color = Color.black;
    }
    }
