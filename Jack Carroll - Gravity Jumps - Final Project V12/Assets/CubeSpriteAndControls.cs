using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpriteAndControls : MonoBehaviour {

     Rigidbody rigB;
    public float speed = 12f;    
    public float jumpHeight = 12f;
    public float smallJumpHeight = 6f;
    public float hopTime = 16f;
    private float maxHoldJumpTime = 15f;
   bool bounce = false;
    bool jumpCancelled = false;
    public bool feetOnGround = false;
    private float groundCount = 0f;

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
            if (Input.GetKey(KeyCode.DownArrow))
                hopTime += Time.time;       
            
         if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        rigB.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        rigB.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && !bounce)
            bounce = true;
            // rigB.AddForce(new Vector3(0, leap, 0),ForceMode.Acceleration);
            // rigB.velocity = new Vector3(rigB.velocity.x, leap, 0);
         rigB.useGravity = true;//http://answers.unity3d.com/questions/648331/how-to-turn-off-gravity.html //Deactivate Gravity at start of game and to reenable it later when falling        
        
            if(hopTime < maxHoldJumpTime)
            {
              hopTime += Time.time * 10f;
            }
            else
            {
                hopTime = maxHoldJumpTime;
            }

            if(maxHoldJumpTime > jumpHeight)
            {
                maxHoldJumpTime = jumpHeight;
            }

         if(hopTime > 0f)
            {
                hopTime = hopTime + smallJumpHeight;
                rigB.AddTorque(hopTime / 10f, hopTime, 0f);
                            
            }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) && !jumpCancelled)
            jumpCancelled = true;
            
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) && !bounce)
                bounce = true;

            rigB.useGravity = true;

            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W) && !jumpCancelled)
                jumpCancelled = true;

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
                rigB.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                rigB.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

            feetOnGround = false;

            hopTime = 0;
        }

        if (feetOnGround)
        {
            groundCount = 0f;
        }
        else                      //http://answers.unity3d.com/questions/984093/if-grounded-false-for-two-seconds-grounded-true.html //Turn on grounded variable after 1.5 seconds
        { 
            groundCount += Time.deltaTime;
        }

        if(groundCount > 2f)
        {
            feetOnGround = true;
        }
        rigB.AddTorque(jumpHeight / 10f, jumpHeight, 0f);
    }

    void FixedUpdate()
    {
        if (bounce)
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

        if (hopTime > maxHoldJumpTime)
        { 
            hopTime = maxHoldJumpTime;
        }
    }
    
void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.name == "Platform" || other.gameObject.name == "Landing Platform" || other.gameObject.tag == "Floating Platform" || other.gameObject.tag == "Floating Cy Platforms") && !feetOnGround)
            feetOnGround = true;

        if (feetOnGround)
        {
            groundCount = 0f;
        }
        else                      //http://answers.unity3d.com/questions/984093/if-grounded-false-for-two-seconds-grounded-true.html //Turn on grounded variable after 1.5 seconds
        {
            groundCount += Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if ((other.gameObject.name == "Platform" || other.gameObject.name == "Landing Platform" || other.gameObject.tag == "Floating Platform" || other.gameObject.tag == "Floating Cy Platforms") && feetOnGround)      
            feetOnGround = false;
      } 
    }

