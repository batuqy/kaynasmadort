using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject character;
    bool kazandin = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            kazandin = true;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(kazandin == true)
            {
                Debug.Log("Kazandiniz!");
            }
            else
            {
                Debug.Log("Game Over!");
            }
        }
    }
}
