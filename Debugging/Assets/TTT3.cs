using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The maths was correct for counting the red spheres!
/// Note the change to the GUI.Label() method.
/// 
/// Challenge 1:  Notice that we populated the array with the values
///                 1, 2 and 3.   These are values that were picked
///                 at random and are difficult to understand.
///                 In code, these are known as "Magic Numbers"
///             Make the code more readable for others!!
///             
///     Hint:  Use constant integers
///     Hint:  Use multiple lines to reflect the relative positions of the
///             values where they are initialised!
///     Hint:  Use the constant integers when performing comparisions in your code.
/// 
/// Challenge 2:  What colour was specified for the cube?
///                 Is the cube the correct colour during game play?
///                 Correct the colour!
/// </summary>
public class TTT3 : MonoBehaviour
{
    int[,] Board = new int[2, 3] { { RED, RED, RED },{ GREEN, GREEN, GREY } };
    const int RED = 1, GREY = 0, GREEN = 2;

    void Start()
    {
        #region Create Board (use zero to represent a gray cube (empty cell))
        for (int Row = 0; Row < 2; Row++)
        {
            for (int Column = 0; Column < 3; Column++)
            {
                if (Board[Row, Column] == GREY)
                {
                    GameObject newCell = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    newCell.GetComponent<Renderer>().material.color = new Color(20f, 20f, 20f);
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

    void Update()
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
                if (Board[Row, Column] == RED)
                    NumberOfRedCells++;
            }
        }
        #endregion

        #region Display count on screen
        string stringToDisplay = "Number of Red = " + NumberOfRedCells.ToString();
        GUI.Label(new Rect(0, 0, 200, 20), stringToDisplay);
        #endregion
    }

}
