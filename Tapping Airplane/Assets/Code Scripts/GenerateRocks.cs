using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRocks : MonoBehaviour
{
    public GameObject rocks;
    int score = 0;

	void Start ()
    {
        InvokeRepeating("CreateRockObstacle", 1f, 2f);
	}

     void OnGUI()
    {
        GUI.color = Color.green;
        GUILayout.Label("Score: " + score.ToString());
    }

    void CreateRockObstacle()
    {
        Instantiate(rocks);
        score++;
	}
}