using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchParthenonScene : MonoBehaviour {

    public AudioClip thumpingWall;

    void Start () {
	
	}

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "Collider")
        {
            GetComponent<AudioSource>().Play();
            Destroy(col.gameObject);
            SceneManager.LoadScene("Temple Of Doom");

        }
    }
}
