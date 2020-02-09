using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Plane : MonoBehaviour
{
    public Vector2 jump = new Vector2(0, 250);

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jump);
        }

        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.y > Screen.height || screenPos.y < 0)
        {
            GameOver();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver();
    }

    void GameOver()
      {
        SceneManager.LoadScene("Rock Flyover");
      }
	}