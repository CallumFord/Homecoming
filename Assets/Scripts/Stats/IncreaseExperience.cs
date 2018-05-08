using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperience
{
    //private static LevelUp levelUp = new LevelUp();
    public static void AddExperience(int XP) //Increases player experience for every player in the party and checks if conditions for level up are met
    {
        foreach(BasePlayer Player in GameInformation.PartyList)
        {
            Player.CurrentExp += XP;
            while (Player.CurrentExp >= Player.RequiredExp)
                LevelUp.LevelUpCharacter(Player);
        }
    }
}
