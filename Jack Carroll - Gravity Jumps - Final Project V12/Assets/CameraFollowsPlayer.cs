using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour {

    public GameObject cameraTarget;
    private Transform target;
    private Transform exLeft;
    private Transform exRight;

     void Start()
    {
        target = GameObject.Find("Player").transform;  
    }
    
	void Update ()
    {
        Vector3 pos = target.position; //http://answers.unity3d.com/questions/595977/moving-camera-with-player-in-2d.html //Attempt to move camera along with player
        pos.z = transform.position.z;
        pos.z = target.position.z;
        pos.z = Mathf.Clamp(pos.z, exLeft.position.z, exRight.position.z);
        transform.position = pos;
        transform.LookAt(cameraTarget.transform); //https://code.tutsplus.com/tutorials/unity3d-third-person-cameras--mobile-11230 //Camera following cube     	
    }
}
