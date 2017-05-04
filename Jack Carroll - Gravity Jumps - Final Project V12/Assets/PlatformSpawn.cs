using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawn : MonoBehaviour
{

    public int cylinderPlStyle = 25;

    void Start()
    {

        GameObject platformSpawner = GameObject.CreatePrimitive(PrimitiveType.Cube);

        platformSpawner.name = "Platform";

        platformSpawner.tag = "Floating Platform";

        platformSpawner.transform.localPosition += new Vector3(-14.4f, -9, 1);

        platformSpawner.transform.localScale = new Vector3(6, 1.8f, 1);

        for (int i = 0; i < cylinderPlStyle; i++)
        {
            GameObject platformTarget = GameObject.CreatePrimitive(PrimitiveType.Capsule);

            platformTarget.tag = "Floating Cy Platforms";

            platformTarget.name = "Landing Platform";         

            platformTarget.GetComponent<Renderer>().material.color = Color.green;

            platformTarget.transform.position += new Vector3(Random.Range(-7f, 29f), Random.Range(-7f, 9f), 1);

            platformTarget.transform.localEulerAngles += new Vector3(0, 0, 90.0f);

            platformTarget.transform.localScale = new Vector3(3, 1.8f, 1);
        }
    }

     void Update()
    {

    }

}
