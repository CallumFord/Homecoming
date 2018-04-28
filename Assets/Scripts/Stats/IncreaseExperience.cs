using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseExperience
{
    //private static LevelUp levelUp = new LevelUp();
    public static void AddExperience(int XP) //Increases player experience for every player in the party and checks if conditions for level up are met
    {
        GameInformation.Player1Experience += XP;
        if (GameInformation.Player1Experience >= GameInformation.Player1Required)
        {
            BaseCharacterClass playerClass = new BaseHeroClass();
            LevelUp.LevelUpCharacter(playerClass, GameInformation.Player1Level);
        }
        if (GameInformation.Player2 != 0)
        {
            GameInformation.Player2Experience += XP;
            if (GameInformation.Player2Experience >= GameInformation.Player2Required)
            {
                //Level Up Function
            }
        }
        if (GameInformation.Player3 != 0)
        {
            GameInformation.Player3Experience += XP;
            if (GameInformation.Player3Experience >= GameInformation.Player3Required)
            {
                //Level Up Function
            }
        }
        if (GameInformation.Player4 != 0)
        {
            GameInformation.Player4Experience += XP;
            if (GameInformation.Player4Experience >= GameInformation.Player4Required)
            {
                //Level Up Function
            }
        }
    }

}
