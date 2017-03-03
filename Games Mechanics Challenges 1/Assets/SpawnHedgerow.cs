using UnityEngine;
using System.Collections;

public class SpawnHedgerow : MonoBehaviour
{

    public int hedge = 5, cube = 0;


    void Start()
    {
        while (cube < hedge)
        {
            GameObject newCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

            newCube.name = "Cube " + cube;

            newCube.transform.position += new Vector3(cube, 0, 0);

            cube++;


        }



    }
}
