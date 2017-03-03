using UnityEngine;
using System.Collections;

public class SpawnStairs : MonoBehaviour {

    public int stairs = 2,units = 0;

	
	void Start () {
        while (stairs > units)
        {
            GameObject SpawningStairs = GameObject.CreatePrimitive(PrimitiveType.Cube);

            SpawningStairs.name = "Cube " + units;

            SpawningStairs.transform.position += new Vector3(units, units, 0);

            units++;

        }


	
	}
	
	
}
