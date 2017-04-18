using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpriteAndControls : MonoBehaviour {

     Rigidbody rigB;
    public float speed = 3.5f;
    public float leap = 20.5f;
    public float jumpVal = 2;
    public float maxJumpVal = 4;
    public float minJumpVal = 4;
    bool fall;
    
	void Start () {
        GameObject cubeHunter = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubeHunter.name = "Player";

        cubeHunter.GetComponent<Renderer>().material.color = Color.blue;

        cubeHunter.transform.position += new Vector3(-13.4f, 0, 1);

        rigB = cubeHunter.AddComponent<Rigidbody>(); //http://answers.unity3d.com/questions/19466/how-do-i-add-a-rigidbody-in-script.html //Set up RigidBody for square
        rigB.useGravity = true;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling
        rigB.freezeRotation = true;//http://answers.unity3d.com/questions/38542/prevent-rigidbody-from-rotating.html //Disable Rigidbody rotation in Vector3 (x,y,z) 

    }

	
	void Update() { 

        rigB.GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            rigB.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            rigB.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
            rigB.AddForce(new Vector3(0, leap, 0),ForceMode.Acceleration);
            // rigB.velocity = new Vector3(rigB.velocity.x, leap, 0);
         rigB.useGravity = true;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling
       
      }
        
          
   void onTriggerEnter()
     {
         fall = true;                                                                                                                                
     }
    void OnTriggerExit()
    {
        fall = false;
    }
}

