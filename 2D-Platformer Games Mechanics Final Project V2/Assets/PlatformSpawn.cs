using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour {

	
	void Start () {
        GameObject platformSpawner = GameObject.CreatePrimitive(PrimitiveType.Cube);

        platformSpawner.name = "Platform";

        platformSpawner.transform.localPosition += new Vector3(-13.4f, -9, 1);

        platformSpawner.transform.localScale = new Vector3(6, 1.8f, 1);


        GameObject platformTarget = GameObject.CreatePrimitive(PrimitiveType.Capsule);

         platformTarget.name = "Landing Platform";

        platformTarget.GetComponent<Renderer>().material.color = Color.green;

        platformTarget.transform.position += new Vector3(Random.Range(-10f,3f), Random.Range(-10f, 3f), 1);

        platformTarget.transform.localEulerAngles += new Vector3(0, 0, 90.0f);

        platformTarget.transform.localScale = new Vector3(3, 1.8f, 1);

    }
	
	
	void Update () {
        
		
	}
}
