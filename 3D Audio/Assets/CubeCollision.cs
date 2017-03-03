using UnityEngine;
using System.Collections;

public class CubeCollision : MonoBehaviour {

   public AudioClip thumpingWall;
    

    void Start()
    {

    }

	void OnCollisionEnter (Collision col)
    {
    
     if(col.gameObject.name == "Player")
        {
            GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);

        }
    }
}
