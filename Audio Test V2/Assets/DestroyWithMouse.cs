using UnityEngine;
using System.Collections;

public class DestroyWithMouse : MonoBehaviour {



    void Update () {
        if(Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

         if(Physics.Raycast(ray,out hit))
            {

                BoxCollider boxC = hit.collider as BoxCollider;
                if(boxC != null)
                {
                    Destroy(boxC.gameObject);
                }

            }

        }
	
	}
}
