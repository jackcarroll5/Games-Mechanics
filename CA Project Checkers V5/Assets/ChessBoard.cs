using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessBoard : MonoBehaviour
{
    //Best Practice:  Avoid using "Magic Numbers" to add clarity to your code!
    const int BOARD_WIDTH = 8;
    const int BOARD_HEIGHT = 8;
	// Use this for initialization
	void Start ()
    {
        //Create a flat chess board
        for (int z = 0; z <= BOARD_HEIGHT; z++)
        {
	        for (int x = 0; x <= BOARD_WIDTH; x++)
            {
                //Add a white or black cell to the chessboard
                GameObject square = GameObject.CreatePrimitive(PrimitiveType.Cube);
                square.transform.position += new Vector3(x, -0.5f, z);
                square.tag = "White";

                //Alternate colour of the square across the row.  Alternate first cell colour on each row as well!
                if ((x % 2) == (z % 2))
                {
                    square.GetComponent<Renderer>().material.color = Color.black;
                    square.tag = "Black";   //Change the tag if this is a black cell!
                }

            }
        }
	}
}
