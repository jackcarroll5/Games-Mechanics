using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class KeyChange : MonoBehaviour {
		
	void Update () {

        if(Input.GetKey("space"))
        {

            SceneManager.LoadScene("Temple of Doom");

        }
	
	}
}
