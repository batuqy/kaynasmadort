using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateDice : MonoBehaviour
{
    public GameObject dice; 
    public void getDice()
    {
        Instantiate(dice);
        dice.transform.position = new Vector2(985, 710);

    }
}
