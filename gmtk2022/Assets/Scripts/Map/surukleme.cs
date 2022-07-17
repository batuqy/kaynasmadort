using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surukleme : MonoBehaviour
{
    private bool isDragging;
    private Vector2 basePosition;
    private void Start()
    {
        basePosition = new Vector2(this.gameObject.transform.position.x, this.gameObject.transform.position.y);
    }
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
        this.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
        if(this.gameObject.transform.position.y <= -10f)
        {
            this.GetComponent<Rigidbody2D>().gravityScale = 0;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.transform.position = basePosition;
        }
    }
}