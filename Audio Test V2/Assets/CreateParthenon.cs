using UnityEngine;
using System.Collections;

public class CreateParthenon : MonoBehaviour {

   public int floor = 1 , units = 0, roof = 1, sidePillars = 18, frontBackPillars = 6,randomColumns = 20,spawned = 0;

	void Start () {

        GameObject createFloor = GameObject.CreatePrimitive(PrimitiveType.Cube);

        createFloor.name = "Floor";

        createFloor.transform.localScale += new Vector3(60, 0, 100);

        createFloor.transform.position += new Vector3(0, -2, 0);

        while (units < sidePillars)
        {


            GameObject newSidePillar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            newSidePillar.name = "Side Pillar " + sidePillars;

            newSidePillar.transform.position = new Vector3(0, 2, units * 2);

            newSidePillar.transform.localScale += new Vector3(0, 4, 0);

            units++;
        }

        units = 0;

        while (units < frontBackPillars)
        {


            GameObject newfrontBackPillar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            newfrontBackPillar.name = "Front Pillar " + frontBackPillars;

            newfrontBackPillar.transform.position = new Vector3(units, 2, 0 * 2);

            newfrontBackPillar.transform.localScale += new Vector3(0, 4, 0);

            units++;
        }

        units = 0;

        while (units < sidePillars)
        {


            GameObject newSidePillar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            newSidePillar.name = "Side Pillar " + sidePillars;

            newSidePillar.transform.position = new Vector3(5, 2, units * 2);

            newSidePillar.transform.localScale += new Vector3(0, 4, 0);

            units++;
        }

        units = 0;

        while (units < frontBackPillars)
        {


            GameObject newfrontBackPillar = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            newfrontBackPillar.name = "Back Pillar " + frontBackPillars;

            newfrontBackPillar.transform.position = new Vector3(units, 2, 18 * 2);

            newfrontBackPillar.transform.localScale += new Vector3(0, 4, 0);

            units++;
        }

        units = 0;

        while (units < roof)
        {


            GameObject newRoof = GameObject.CreatePrimitive(PrimitiveType.Cube);

            newRoof.name = "Roof " + roof;

            newRoof.transform.localScale += new Vector3(36, 0, 5.2f);

            newRoof.transform.eulerAngles = new Vector3(0,90,0);

            newRoof.transform.position = new Vector3(2.6f, 6.7f, 18);

            units++;
        }

        while(randomColumns > spawned)
        {

            GameObject randomCy = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

            randomCy.name = "Extra Cylinders " + spawned;

            randomCy.transform.position += new Vector3(Random.Range(0, 5), 2, Random.Range(0, 36));

            randomCy.transform.localScale += new Vector3(0, 4, 0);

            spawned++;
        }


    }
	
	
}
