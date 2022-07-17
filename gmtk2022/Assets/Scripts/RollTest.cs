using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RollTest : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texts;
    [SerializeField] TextMeshProUGUI totalValue;
    public int sides;
    public int rollValue;
    public static int toplam;
    private static int x=20;
    private float y;
    public GameObject enableGameObject;
    public void setRandomtoRollValue()
    {
        rollValue = UnityEngine.Random.Range(1, sides + 1);
    }

    public void Roll()
    {
        
        if (toplam < 20 )
        {
            
            if (sides >x)
            {
                Debug.Log("yok");
                texts.text = "X";

            }
            else
            {
                enableGameObject.SetActive(true);
                setRandomtoRollValue();
                x = x - rollValue; 
                TotalValue();
                UpdateText();
            }
        }
        else
        {
            Debug.Log("yok");
            texts.text = "X";
        }
        
        
    }
    public int TotalValue()
    {
        toplam += rollValue;
        return toplam;
    }
    private void UpdateText()
    {
     texts.text =rollValue.ToString();
     totalValue.text = (toplam).ToString();
    }
}
