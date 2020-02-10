using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// There is a more visual correspondence between the values in the array
///    and the manner is which they are displayed during game play in this version.
///    
/// Remember to use the OnGUI() method for displaying text.
/// 
/// Challenge:  Is the count of Red Sphere correct?  Why not?
/// 
/// </summary>
public class TTT2 : MonoBehaviour
{
    int[,] Board = new int[2, 3] { { 1, 1, 1 },{ 2, 2, 0 }  };

	void Start ()
    {
        #region Create Board (use zero to represent a gray cube (empty cell))
        for (int Row = 0; Row < 2; Row++)
        { 
            for (int Column = 0; Column < 3; Column++)
            {
                if (Board[Row, Column] == 0)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    newCell.GetComponent<Renderer>().material.color = new Color(20f, 20f, 20f);
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
                else if (Board[Row, Column] == 1)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.red;
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
                else if (Board[Row, Column] == 2)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.green;
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
            }
        }
        #endregion Board created 
    }

	void Update ()
    {

    }

    private void OnGUI()
    {
        #region Count Red Spheres
        int NumberOfRedCells = 0;
        //Now count the number of red cells
        for (int Row = 0; Row < 2; Row++)
        {
            for (int Column = 0; Column < 3; Column++)
            {
                if (Board[Row, Column] == 1)
                    NumberOfRedCells++;
            }
        }
        #endregion
        #region Display count on screen
        string stringToDisplay = "Number of Red = " + NumberOfRedCells.ToString();
        GUI.Label(new Rect(13, 5, 140, 20), stringToDisplay);
        #endregion
    }

}



