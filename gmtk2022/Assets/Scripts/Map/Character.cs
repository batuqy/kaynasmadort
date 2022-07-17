using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject line1,line2,line3,line4,line5,line6;
    Queue myQ = new Queue();
    public GameObject character;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            while(myQ.Count != 0)
            {
                if(myQ.Peek() == "r")
                {
                    myQ.Dequeue();
                    character.transform.position = new Vector2(character.transform.position.x + 0.25f, character.transform.position.y);
                }
                else if(myQ.Peek() == "d")
                {
                    myQ.Dequeue();
                    character.transform.position = new Vector2(character.transform.position.x, character.transform.position.y - 0.25f);
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "line1")
        {
            line1.GetComponent<Rigidbody2D>().gravityScale = 0;
            line1.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            line1.transform.position = new Vector2(7.43f, 4.34f);
            myQ.Enqueue("r");
        }
        else if (collision.gameObject.tag == "line2")
        {
            line2.GetComponent<Rigidbody2D>().gravityScale = 0;
            line2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            line2.transform.position = new Vector2(7.48f, 3.17f);
            myQ.Enqueue("r");
            myQ.Enqueue("d");
            line2.GetComponent<Rigidbody2D>().gravityScale = 0;
        }
        else if (collision.gameObject.tag == "line3")
        {
            line3.GetComponent<Rigidbody2D>().gravityScale = 0;
            line3.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            line3.transform.position = new Vector2(7.9f, 1.9f);
            myQ.Enqueue("r");
            myQ.Enqueue("d");
            myQ.Enqueue("r");
        }
        else if (collision.gameObject.tag == "line4")
        {
            line4.GetComponent<Rigidbody2D>().gravityScale = 0;
            line4.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            line4.transform.position = new Vector2(7.9f, 0.5f);
            myQ.Enqueue("r");
            myQ.Enqueue("r");
            myQ.Enqueue("d");
        }
        else if (collision.gameObject.tag == "line5")
        {
            line5.GetComponent<Rigidbody2D>().gravityScale = 0;
            line5.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            line5.transform.position = new Vector2(7.9f, -1.9f);
            myQ.Enqueue("r");
            myQ.Enqueue("r");
            myQ.Enqueue("d");
            myQ.Enqueue("d");
        }
        else if (collision.gameObject.tag == "line6")
        {
            line6.GetComponent<Rigidbody2D>().gravityScale = 0;
            line6.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            line6.transform.position = new Vector2(7.9f, -3.8f);
            myQ.Enqueue("d");
        }
    }
}
