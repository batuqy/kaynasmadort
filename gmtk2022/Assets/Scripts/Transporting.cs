using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transporting : MonoBehaviour
{
    public GameObject nesne;
    [SerializeField] private float _moveTime;
    void Start()
    {
        nesne.transform.localPosition = new Vector2(0.65f*PlayerPrefs.GetInt("x"),0.65f*PlayerPrefs.GetInt("y"));
    }

    public void Move()
    {
        StartCoroutine("moveTimer");
    }

    IEnumerator moveTimer()
    {
        for (int i = 0; i < 100 ; i++)
        {
            yield return new WaitForSeconds(0.01f);   
            nesne.transform.localPosition = Vector2.MoveTowards(nesne.transform.localPosition,new Vector2(0.65f*PlayerPrefs.GetInt("x"),0.65f*PlayerPrefs.GetInt("y")),_moveTime*Time.deltaTime);
        }
        GameObject.FindGameObjectWithTag("GameController").GetComponent<Dice>().X = 0;
        GameObject.FindGameObjectWithTag("GameController").GetComponent<Dice>().Y = 0;
    }
}
