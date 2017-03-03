using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboticCollider : MonoBehaviour {


    void OnCollisionEnter(Collision col)
    {


        if (col.gameObject.name == "Robotic Cube")
        {
            GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);

        }
    }



}
