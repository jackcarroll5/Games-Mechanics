using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerMovement : MonoBehaviour {

public int speed;
    public Rigidbody rb;   

	void Update () {

        GameObject [] whiteCheckerArray = GameObject.FindGameObjectsWithTag("White");
        foreach(GameObject whiteChecker in whiteCheckerArray)

            
      
        if(Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position += new Vector3(0.05f, 0, 0.05f);
             this.transform.position += new Vector3 (0,0,0);  
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += new Vector3(-1, 0, -1);
            this.transform.position += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += new Vector3(-1, 0, 1);
            this.transform.position += new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            this.transform.position += new Vector3(1, 0, -1);
            this.transform.position += new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.position += new Vector3(0, 0, 0);
            speed = 0;
            this.transform.position += new Vector3(0, 0, 0);

        }
        this.transform.position += new Vector3(0, 0, 0);
    }
}
