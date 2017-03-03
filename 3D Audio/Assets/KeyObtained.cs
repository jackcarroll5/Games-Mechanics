using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KeyObtained : MonoBehaviour {

    public AudioClip shiningKeyCollect;

    void Start () {
	
	}

    
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.name == "Player")
        {
            GetComponent<AudioSource>().Play();
            Destroy(gameObject);
            SceneManager.LoadScene("Temple of Hope");


        }
}
}
