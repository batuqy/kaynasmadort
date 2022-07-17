using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RollTest : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texts;
    [SerializeField] TextMeshProUGUI[] textsOndice;
    [SerializeField] TextMeshProUGUI totalValue;
    public int sides;
    public int rollValue;
    public static int toplam;
    private static int x=20;
    private static int kont;

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

            if (sides > x)
            {
                if (sides > x)
                {
                    for (int i = 6; i < 0; i--)
                    {
                        kont = toplam + sides;
                        if (kont < 20)
                        {
                            textsOndice[i].text = "X";
                        }
                    }
                }
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
            if (sides > x)
            {
                for (int i = 6; i < 0; i--)
                {
                    kont = toplam + sides;
                    if (kont < 20)
                    {
                        textsOndice[i].text = "X";
                    }
                }
            }
        }
        if (sides > x)
        {
            for (int i = 6; i < 0; i--)
            {
                kont = toplam + sides;
                if (kont < 20)
                {
                    textsOndice[i].text = "X";
                }
            }
        }
    }
    public void FixedUpdate()
    {
        if (sides > x)
        {
            kont = toplam + sides;
            if (kont < 21)
            {
                for (int i = 6; i < 0; i--)
                {
                    textsOndice[i].text = "X";
                }
            }
                
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


    public static float xD = 1;
    public static float yD = 1;
    private static float tapCounter = 0;
    int[] xyz = new int[] { 4, 6, 8, 10, 12, 20 };
    [SerializeField] TextMeshProUGUI textXd;
    [SerializeField] TextMeshProUGUI textYd;

    public void giveDirectionNumber()
    {
        if (tapCounter == 0)
        {
            xD = RollTest.toplam;
            tapCounter++;
            textXd.text = xD.ToString();
            toplam = 0;
            totalValue.text = (toplam).ToString();
            x = 20;
            for (int i = 0; i<6 ; i++)
            {
                    textsOndice[i].text = xyz[i].ToString();
            }
            
        }
        else if (tapCounter == 1)
        {
            tapCounter++;
            yD = RollTest.toplam;
            textYd.text = yD.ToString();
            toplam = 0;
            totalValue.text = (toplam).ToString();
            x = 20;
            for (int i = 0; i < 6; i++)
            {
                textsOndice[i].text = xyz[i].ToString();
            }
        }
    }
}

