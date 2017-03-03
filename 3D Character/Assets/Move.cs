using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	// Use this for initialization
   public void Start()
    {
       
    }
    public float speed = 20f;
    // Update is called once per frame
	void Update () { 
        this.transform.position += new Vector3(0.2f, 0.8f, 0.6f);

        transform.Rotate(Vector3.up * Time.deltaTime,speed);

        transform.Translate(Vector3.back * Time.deltaTime);

        Destroy(this,2f);
	}
}
