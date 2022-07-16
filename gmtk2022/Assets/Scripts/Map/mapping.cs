using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapping : MonoBehaviour
{
    public GameObject nesne;
    void Start()
    {
        float row, column;
        row = Random.Range(1, 7);
        column = Random.Range(-2, 4);
        Instantiate(nesne);
        nesne.transform.position = new Vector2(row - 6.5f, column-0.5f);
    }

    void Update()
    {
        
    }
}
