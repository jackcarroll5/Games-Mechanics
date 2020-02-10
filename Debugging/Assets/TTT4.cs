using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Final version:
///     No Magic Numbers
///     The cube is gray as Colour values range from 0 to 1f.
///     The shapes display as entered in the array.
///     The size of the GUI rectangle is large enough to fit the entire string.
/// </summary>
public class TTT4 : MonoBehaviour
{
    const int GRAY = 0, RED = 1, GREEN = 2;
    int[,] Board = new int[2, 3]  { { RED,      RED,        RED }, 
                                    { GREEN,    GREEN,      GRAY } };

    void Start()
    {
        #region Create Board (use zero to represent a gray cube (empty cell))
        for (int Row = 0; Row < 2; Row++)
        {
            for (int Column = 0; Column < 3; Column++)
            {
                if (Board[Row, Column] == GRAY)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    newCell.GetComponent<Renderer>().material.color = new Color(0.5f, 0.5f, 0.5f);
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
                else if (Board[Row, Column] == RED)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.red;
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
                else if (Board[Row, Column] == GREEN)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    newCell.GetComponent<Renderer>().material.color = Color.green;
                    newCell.transform.position += new Vector3(Column, 0f, -Row);
                }
            }
        }
        #endregion Board created 
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
                if (Board[Row, Column] == RED)
                    NumberOfRedCells++;
            }
        }
        #endregion

        #region Display count on screen
        string stringToDisplay = "Number of Red equals " + NumberOfRedCells.ToString();
        GUI.Label(new Rect(0, 0, 200, 20), stringToDisplay);
        #endregion
    }

}
