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
    diceRoll diceRoll;
    

    private void Start()
    {
    diceRoll = new diceRoll(sideValue.sideValue);
    }
    public void Roll()
    {
        
        diceRoll.Roll();
        UpdateText();
    }

   

    private void UpdateText()
    {
     texts.text = diceRoll.dice.rollValue.ToString();
        totalValue.text = (diceRoll.toplam).ToString();
    }
}
