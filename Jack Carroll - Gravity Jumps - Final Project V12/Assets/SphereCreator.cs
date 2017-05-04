using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreator : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        this.transform.localPosition += new Vector3(-15.1f, -7.7f, 1);
    }

    // Update is called once per frame
    void Update () {

        if(Input.GetKeyUp(KeyCode.Space))
        {
            this.GetComponent<Renderer>().material.color = Color.red;
            this.GetComponent<Rigidbody>().velocity += new Vector3(0,2,0);

        }
		
	}
}
