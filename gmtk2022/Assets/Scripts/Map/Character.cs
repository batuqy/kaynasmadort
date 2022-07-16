using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Transform line1,line2,line3,line4,line5,line6;
    Queue myQ = new Queue();
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
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "line1")
        {
            line1.position = new Vector2(8.43f, 4.34f);
            myQ.Enqueue("r");
        }
        else if(collision.gameObject.tag == "line2")
        {
            line2.position = new Vector2(8.48f,3.17f);
            myQ.Enqueue("r");
            myQ.Enqueue("d");
        }
        else if (collision.gameObject.tag == "line3")
        {
            line3.position = new Vector2(8.9f, 1.9f);
            myQ.Enqueue("r");
            myQ.Enqueue("d");
            myQ.Enqueue("r");
        }
        else if (collision.gameObject.tag == "line4")
        {
            line4.position = new Vector2(8.9f, 0.5f);
            myQ.Enqueue("r");
            myQ.Enqueue("r");
            myQ.Enqueue("d");
        }
        else if (collision.gameObject.tag == "line5")
        {
            line6.position = new Vector2(8.9f, -1.9f);
            myQ.Enqueue("r");
            myQ.Enqueue("r");
            myQ.Enqueue("d");
            myQ.Enqueue("d");
        }
        else if (collision.gameObject.tag == "line6")
        {
            line6.position = new Vector2(8.9f, -3.8f);
            myQ.Enqueue("d");
        }
    }
}
