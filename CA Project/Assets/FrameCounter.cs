using UnityEngine;
using System.Collections;

public class FrameCounter : MonoBehaviour {

    public int frame = 0, FPS = 0;

	void Update () {

        frame++;

        FPS = frame / (int)Time.time;
            
            
            
	}
}
