using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money
{
    public static void IncreaseMoney(int Money) //Adds given value to player funds (From enemy drops/selling)
    {
        GameInformation.Money += Money;
    }
    public static void DecreaseMoney(int Money) //Checks if player has enough funds before subtracting value (For purchasing items)
    {
        if (Money >= GameInformation.Money)
        {
            GameInformation.Money -= Money;
        }
    }

}
