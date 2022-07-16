using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RollTest : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI texts;
    [SerializeField] TextMeshProUGUI totalValue;
    public scriptableDice sideValue;
    public int sides;
    public int rollValue;
    public void Rolldice()
    {
        rollValue = UnityEngine.Random.Range(1, sides + 1);
    }
    public static int toplam;
    public void Roll()
    {
        Rolldice();
        TotalValue();
        UpdateText();
    }
    public int TotalValue()
    {
        toplam += rollValue;
        Debug.Log(toplam);
        return toplam;
    }
    private void UpdateText()
    {
     texts.text =rollValue.ToString();
     totalValue.text = (toplam).ToString();
    }
}
