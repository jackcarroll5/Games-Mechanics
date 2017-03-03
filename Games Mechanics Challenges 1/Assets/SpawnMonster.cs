using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour {

    public int monster = 20,spawned = 0;

	
	void Start () {      
       
        while (monster > spawned)
        {
                        
                GameObject spawnMonsterBody = GameObject.CreatePrimitive(PrimitiveType.Cube);

            GameObject sphereOverCube = GameObject.CreatePrimitive(PrimitiveType.Sphere);

                spawnMonsterBody.name = "Body " + spawned;                 

                sphereOverCube.name = "Head " + spawned;
            //transform.position = new Vector3);         

            sphereOverCube.transform.position = new Vector3(0, 1, 0);

            sphereOverCube.transform.parent = spawnMonsterBody.transform;

           spawnMonsterBody.transform.position += new Vector3(Random.Range(-6f, 3f), 0, Random.Range(-6f, 3f));

            spawned++;

        }
    
	
	}
	
}
