using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapping : MonoBehaviour
{
    public GameObject nesne;
    public static float row, column;
    void Start()
    {
        Debug.Log(PlayerPrefs.GetFloat("xD"));
        Debug.Log(PlayerPrefs.GetFloat("yD"));
        row = Random.Range(1, 21);
        column = Random.Range(1, 21);
        Instantiate(nesne);
        nesne.transform.position = new Vector2(row * 0.25f - 3.625f, 4.375f - column * 0.25f);
    }

    void Update()
    {
        
    }
}
