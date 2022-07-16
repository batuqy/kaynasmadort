using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class RollTest : MonoBehaviour
{
    [SerializeField] List<TextMeshProUGUI> texts;
    public scriptableDice sideValue;
    diceRoll diceRoll;
    private void Start()
    {
        
        diceRoll = new diceRoll();
        for (int i = 0; i < 5; i++)
        {
            diceRoll.AddDice(sideValue.sideValue);
        }
        
    }
    public void Roll()
    {
        
        diceRoll.Roll();

        UpdateText();
    }

    private void UpdateText()
    {
        for (int i = 0; i < texts.Count; i++)
        {
            if (i <diceRoll.dice.Count)
            {
                texts[i].text = diceRoll.dice[i].rollValue.ToString();
            }
        }
       
    }
}
