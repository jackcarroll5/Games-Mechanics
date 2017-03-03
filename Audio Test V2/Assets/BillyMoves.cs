using UnityEngine;
using System.Collections;

public class BillyMoves : MonoBehaviour {

	
	void Update () {
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(-0.3f,0,0);

        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(0.3f, 0, 0);

        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0, 0, -0.3f);

        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0, 0, 0.3f);
    }
}
