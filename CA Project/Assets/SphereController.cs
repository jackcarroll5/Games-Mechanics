using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

    private float xPos = 0, zPos = 0;

	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            this.transform.position += new Vector3(0.1f, 0, 0);

            xPos += 0.1f;
            zPos += 0.1f;

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            this.transform.position += new Vector3(-0.1f, 0, 0);

            xPos -= 0.1f;
            zPos -= 0.1f;

        }

        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.transform.position += new Vector3(0, 0, 0.1f);

            xPos += 0.1f;
            zPos += 0.1f;

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {

            this.transform.position += new Vector3(0, 0, -0.1f);

            xPos -= 0.1f;
            zPos -= 0.1f;

        }


    }
}
