using UnityEngine;
using System.Collections;
/// <summary>
/// The purpose of this lab is to create a huge number of cubes 
/// and we'll also learn provate and public variables.
/// We'll be working on primitive game objects and manipulating those newly
/// created game objects.
/// </summary>
public class CubeCreator : MonoBehaviour {

    public int cubesToCreate = 4;



	// Use this for initialization
	void Start () {
        //Create the number of cubes specified by the game designer
        while(cubesToCreate > 0) {

            GameObject newlyCreatedGO = GameObject.CreatePrimitive(PrimitiveType.Cube);
            newlyCreatedGO.name = "Cube " + cubesToCreate;
            newlyCreatedGO.transform.Rotate(Vector3.up * 0.4f, Space.World);
            //            newlyCreatedGO.transform.position += new Vector3(1, 0, 0);

            cubesToCreate--;
        }

    }
	
	// Update is called once per frame
	void Update () {

        //newlyCreatedGO.transform.Rotate(Vector3.up * Time.deltaTime,Space.World);

      if(Input.GetKey ("w"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(0, 0.1f, 0);

        }

        if (Input.GetKey("a"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(-0.1f, 0, 0);

        }

        if (Input.GetKey("s"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(0, -0.1f, 0);

        }

        if (Input.GetKey("d"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(0.1f, 0, 0);

        }

        if (Input.GetKey("q"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(0, 0, 0.1f);

        }

        if (Input.GetKey("e"))
        {

            GameObject.Find("Cube 4").transform.position += new Vector3(0, 0, -0.1f);

        }


        if (Input.GetMouseButton(0))
        {

            GameObject.Find("Cube 3").transform.position += new Vector3(0.1f, 0, -0.1f);

        }



        GameObject.Find("Cube 3").transform.Rotate(Vector3.left * 0.9f);
        

        GameObject.Find("Cube 2").transform.Translate(Vector3.up * 0.01f);

        GameObject.Find("Cube 2").transform.InverseTransformPoint(Vector3.one);

        GameObject.Find("Cube 1").transform.Translate(Vector3.back * Time.deltaTime);

        Destroy(gameObject, 30f);

    }
}
