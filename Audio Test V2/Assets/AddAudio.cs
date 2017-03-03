using UnityEngine;
using System.Collections;

public class AddAudio : MonoBehaviour {

    public int seconds = 3;
    AudioSource source;

    void Start () {

        source = this.gameObject.AddComponent<AudioSource>();
        source.clip = (AudioClip)Resources.Load("PowUp_01");
        source.volume = 0.995f;
        source.loop = true;
        source.Play();

      

    }
	
	
	void Update () {

        if (Input.GetKey("w"))
        {
            source.volume += 0.1f;
        }

        if (Input.GetKey("s"))
        {
            source.volume -= 0.1f;
        }

    }
}
