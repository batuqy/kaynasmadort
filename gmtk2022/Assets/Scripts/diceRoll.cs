using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dice
{
    public int sides;
    public int rollValue;
    
    public Dice(int sides)
    {
        this.sides = sides;
    }

    public void Roll()
    {
        rollValue = UnityEngine.Random.Range(1, sides + 1);
    }
}
public class diceRoll 
{
    public Dice dice;
    public static int toplam;
    public diceRoll(int sides)
    {
        dice = new Dice(sides);
    }
  
    public void Roll()
    {

            dice.Roll();

        TotalValue();
    }
    public int TotalValue()
    {
        
        toplam += dice.rollValue;
        Debug.Log(toplam);
        return toplam;
        
    }

   
}
