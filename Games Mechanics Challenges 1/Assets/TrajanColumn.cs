using UnityEngine;
using System.Collections;

public class TrajanColumn : MonoBehaviour {


    public int column = 10,cube = 0;
	
	void Start () {
	
    while(cube < column)
        {

            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            newCube.name = "Cube " + cube;

           newCube.transform.position += new Vector3(0, cube, 0);

            cube++;

        }
	}
	
}
