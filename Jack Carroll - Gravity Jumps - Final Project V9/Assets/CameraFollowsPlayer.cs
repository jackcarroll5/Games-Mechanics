using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsPlayer : MonoBehaviour {

    public GameObject cameraTarget;

	void Update ()
    {
        transform.LookAt(cameraTarget.transform); //https://code.tutsplus.com/tutorials/unity3d-third-person-cameras--mobile-11230 //Camera following cube     	
    }
}
