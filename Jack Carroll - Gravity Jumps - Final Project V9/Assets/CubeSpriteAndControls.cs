using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpriteAndControls : MonoBehaviour {

     Rigidbody rigB;
    public float speed = 12f;
    public float leap = 60.5f;
    public float jumpHeight = 14f;
    public float smallJumpHeight = 7f;
   bool bounce = false;
    bool jumpCancelled = false;
    public bool feetOnGround = false;


    void Start () {
        GameObject cubeHunter = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cubeHunter.name = "Player";

        cubeHunter.GetComponent<Renderer>().material.color = Color.blue;

        cubeHunter.transform.position += new Vector3(-13.4f, 0, 1);

        rigB = cubeHunter.AddComponent<Rigidbody>(); //http://answers.unity3d.com/questions/19466/how-do-i-add-a-rigidbody-in-script.html //Set up RigidBody for square
        rigB.useGravity = true;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling
        rigB.freezeRotation = true;//http://answers.unity3d.com/questions/38542/prevent-rigidbody-from-rotating.html //Disable Rigidbody rotation in Vector3 (x,y,z) 

        feetOnGround = true;

    }

	
	void Update() {

        rigB.GetComponent<Rigidbody>();

        if(feetOnGround == true)
        { 
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        rigB.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        rigB.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) && !bounce)
            bounce = true;
            // rigB.AddForce(new Vector3(0, leap, 0),ForceMode.Acceleration);
            // rigB.velocity = new Vector3(rigB.velocity.x, leap, 0);
         rigB.useGravity = true;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && !jumpCancelled)
            jumpCancelled = true;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) && !bounce)
                bounce = true;

              rigB.useGravity = true;

            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && !jumpCancelled)
                jumpCancelled = true;

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                rigB.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

           else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                rigB.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

            feetOnGround = false;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if ((other.gameObject.name == "Platform" || other.gameObject.name == "Landing Platform" || other.gameObject.tag == "Floating Platform" || other.gameObject.tag == "Floating Cy Platforms") && !feetOnGround)
            feetOnGround = true;
    }

    void OnCollisionStay(Collision other)
    {
        if ((other.gameObject.name == "Platform" || other.gameObject.name == "Landing Platform" || other.gameObject.tag == "Floating Platform" || other.gameObject.tag == "Floating Cy Platforms") && !feetOnGround)
            feetOnGround = false;
    }

    void OnCollisionExit(Collision other)
    {
        if ((other.gameObject.name == "Platform" || other.gameObject.name == "Landing Platform" || other.gameObject.tag == "Floating Platform" || other.gameObject.tag == "Floating Cy Platforms") && feetOnGround)      
            feetOnGround = false;
    }


    void FixedUpdate()
    {
        if(bounce)
        {
            rigB.velocity = new Vector3(rigB.velocity.x, jumpHeight, 0);
            bounce = false;
            rigB.useGravity = true;


        }
        //https://www.reddit.com/r/Unity3D/comments/26p2yk/variable_jump_height_depending_on_button_push/ //Carry out jump by holding key and letting go of it to end jump (Reduce Velocity) and make player fall due to gravity taking effect once key released
        if (jumpCancelled)
        {
            rigB.velocity = new Vector3(rigB.velocity.x, smallJumpHeight, 0);
            jumpCancelled = false;
            rigB.useGravity = true;

            feetOnGround = false;
        }

    }

}

