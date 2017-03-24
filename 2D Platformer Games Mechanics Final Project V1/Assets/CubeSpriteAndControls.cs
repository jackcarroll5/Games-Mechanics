using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpriteAndControls : MonoBehaviour {

    public Rigidbody rigB;
    public float rotationSpeed = 95.0F;
    public float speed = 45.5f;
    public float jump = 65.5f;
    
	void Start () {
        GameObject cubeHunter = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubeHunter.name = "Player";

        cubeHunter.transform.position += new Vector3(-13.2f, 0, 1);

        rigB = cubeHunter.AddComponent<Rigidbody>(); //http://answers.unity3d.com/questions/19466/how-do-i-add-a-rigidbody-in-script.html //Set up RigidBody for square
        rigB.useGravity = false;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling


    }

	
	void Update() { 

        rigB.GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow))
            rigB.AddForce(Vector3.up,ForceMode.Impulse); 
                 

        if (Input.GetKeyUp(KeyCode.UpArrow))
            rigB.AddForce(Vector3.down, ForceMode.Acceleration);
             

    }        
    
}

