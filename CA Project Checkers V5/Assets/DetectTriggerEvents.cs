using UnityEngine;
using System.Collections;

public class DetectTriggerEvents : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Renderer>().material.color = Color.red;
    }

    public void OnTriggerExit(Collider other)
    {

        other.GetComponent<Renderer>().material.color = Color.white;

    }
}

