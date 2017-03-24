using UnityEngine;
using System.Collections;

public class CheckerDetection : MonoBehaviour
{
    public GameObject whiteCheckerMove;
    public Color checkerColour;

    public void OnTriggerEnter(Collider other)
    {
        checkerColour = other.GetComponent<Renderer>().material.color;
        other.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void OnTriggerExit(Collider other)
    {
        whiteCheckerMove = other.gameObject;
        other.GetComponent<Renderer>().material.color = checkerColour;

        ////if (zPos <= 0.1f && xPos <= 0.1f)
        //{
        //    other.GetComponent<Renderer>().material.color = Color.black;
        //}
        //else
        //    other.GetComponent<Renderer>().material.color = Color.white;
    }

    public void Update()
    {

        if (Input.GetKey(KeyCode.Return))
        {
            whiteCheckerMove.transform.parent = this.transform;
            this.GetComponent<Renderer>().material.color = checkerColour;
            GetComponent<MeshRenderer>().enabled = false;

        }

    } 

  }