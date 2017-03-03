using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {

    public float speed = 1.5f;

    void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.Space))
            this.transform.Rotate(0, 3, 0);
    }

}

