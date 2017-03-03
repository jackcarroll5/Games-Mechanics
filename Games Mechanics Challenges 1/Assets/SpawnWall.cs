using UnityEngine;
using System.Collections;

public class SpawnWall : MonoBehaviour {

    public int length = 10, width = 3 , SpawnedL,SpawnedW;

	void Start () {

     for(SpawnedL = 0; SpawnedL < length; SpawnedL++)
        {

            for (SpawnedW = 0; SpawnedW < width; SpawnedW++)
            {
                GameObject wallSpawnL = GameObject.CreatePrimitive(PrimitiveType.Cube);

                wallSpawnL.name = "Cube " + SpawnedL;

                wallSpawnL.transform.position += new Vector3(SpawnedL, SpawnedW, 0);

            }
         

        }
 

	}
	
}
