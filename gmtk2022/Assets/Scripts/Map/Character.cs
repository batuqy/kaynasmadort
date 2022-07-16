using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject 1,2,3,4,5,6;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.gameObject.transform.position = new Vector2(transform.position.x-1,transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + 1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y - 1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.gameObject.transform.position = new Vector2(transform.position.x + 1, transform.position.y);
        }
    }
}
