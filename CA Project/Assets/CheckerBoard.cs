using UnityEngine;
using System.Collections;

public class CheckerBoard : MonoBehaviour
{

    public int checkersSpawned = 0, piecesSpawned = 0;

    void Start()
    {

        for (int i = 0; i <= 10; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                GameObject checkerCube = GameObject.CreatePrimitive(PrimitiveType.Cube);

                checkerCube.name = "Checkerboard Cube " + i + "" + j;

                checkerCube.transform.position += new Vector3(i, 0.5f, j);

                if (j % 2 == 0 && i % 2 == 0)
                {
                    checkerCube.GetComponent<Renderer>().material.color = Color.black;
                }

                else if (j % 2 != 0 && i % 2 != 0)
                {
                    checkerCube.GetComponent<Renderer>().material.color = Color.black;
                }

                checkersSpawned++;                        //white on black, black on black

            }                                               

        }

        for (int k = 0; k < 4; k++)
        {
            for (int l = 0; l < 5; l++)
            {

                GameObject checkerPiece = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                checkerPiece.name = "Checker Piece " + piecesSpawned;

                if (k % 2 == 0)                                                                      //spawn half the checkers in a for loop
                {                                                                                     //spawn half the checkers in a for loop

                    checkerPiece.transform.position += new Vector3(1 + (l + (l - 1)), 0.5f, k);
                    

                }
                else
                {
                    checkerPiece.transform.position += new Vector3(2 + (l + (l - 1)), 0.5f, k);
                    
                }

                checkerPiece.GetComponent<Renderer>().material.color = Color.white;
                checkerPiece.transform.localScale += new Vector3(0, 0.1f , 0);
                piecesSpawned++;

            }

        }

        for (int k = 0; k < 4; k++)
        {
            for (int l = 0; l < 5; l++)
            {

                GameObject checkerPiece = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

                checkerPiece.name = "Checker Piece " + piecesSpawned;

                if (k % 2 == 0)                                                                      //spawn half the checkers in a for loop
                {                                                                                     //spawn half the checkers in a for loop

                    checkerPiece.transform.position += new Vector3(2 + (l + (l - 1)), 0.5f, 7 + k);


                }
                else
                {
                    checkerPiece.transform.position += new Vector3(1 + (l + (l - 1)), 0.5f, 7 + k);

                }

                checkerPiece.GetComponent<Renderer>().material.color = Color.black;
                checkerPiece.transform.localScale += new Vector3(0, 0.1f, 0);
                piecesSpawned++;


            }

          }

       }

    }
