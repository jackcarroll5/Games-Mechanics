using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlackCells : MonoBehaviour
{

    void Update()
    {
        if (Time.time > 2f)
        {

            GameObject[] allBlackCellArray = GameObject.FindGameObjectsWithTag("Black");
            foreach (GameObject BlackCell in allBlackCellArray)         
                GameObject.Destroy(BlackCell);

        }
    }
}
