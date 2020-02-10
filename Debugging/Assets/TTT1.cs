using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTT1 : MonoBehaviour {

    /// <summary>
    /// Use of a 2D array:
    /// 1.  Create and initialise a 2D array
    /// 2.  Assign value to represent enemies or perhaps checkers.
    /// 3.    The value 0 represents a gray cube.
    /// 4.    The values 1 are red and 2 are green spheres.
    /// We'll use the array to create game objects.
    /// 
    /// Challenge:  Determine if the placement of pieces appears
    ///               to correct when you begin to play the game?
    ///               
    /// </summary>


	void Start () {
        int[,] Board = new int[2,3] { { 2, 2, 0 } ,{ 1,1,1 }, };

        for (int Row = 0; Row < 2; Row++)
            for (int Column = 0; Column < 3; Column++)
            {
                if (Board[Row,Column] == 0 )
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    newCell.GetComponent<Renderer>().material.color = new Color(20f,20f,20f);
                    newCell.transform.position += new Vector3(Column, 0f, Row);
                }
                else if (Board[Row, Column] == 1)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.red;
                    newCell.transform.position += new Vector3(Column, 0f, Row);
                }
                else if (Board[Row, Column] == 2)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.green;
                    newCell.transform.position += new Vector3(Column, 0f, Row);
                }
            }
    }

	void Update () {
        //Next count the number of red cells in the array and display on the screen

    }
}
