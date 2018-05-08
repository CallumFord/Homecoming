using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

    //Maximum Character Level and the experience required to achieve
    private static int maxLevel = 100;
    private static int minLevelExp = 20;
    private static int maxLevelExp = 40000;

    public static void AddExperience(int XP) //Increases player experience for every player in the party and checks if conditions for level up are met
    {
        foreach (BasePlayer Player in GameInformation.PartyList)
        {
            if (Player.PlayerLevel < maxLevel)
                Player.CurrentExp += XP;
                while (Player.CurrentExp >= Player.RequiredExp)
                    LevelUpCharacter(Player);
                Debug.Log(Player.PlayerName + " Lv:" + Player.PlayerLevel + " EXP:" + Player.CurrentExp + "/" + Player.RequiredExp + " HP:" + Player.Health + "/" + Player.Health + " ATK:" + Player.Attack + " DEF:" + Player.Defence + " MAG:" + Player.Magic);
        }
    }

    private static void LevelUpCharacter(BasePlayer Player)
    {
        Player.PlayerLevel += 1;
        AssignNewStats(Player);
    }

    private static void AssignNewStats(BasePlayer Player)
    {
        //Assigns the player new stats by interpolating between their minimum and maximum values appropriately for their current level 
        Player.Attack = CalculateNewStats(Player.PlayerClass.BaseAttack, Player.PlayerClass.MaxAttack, Player.PlayerLevel);
        Player.Defence = CalculateNewStats(Player.PlayerClass.BaseDefence, Player.PlayerClass.MaxDefence, Player.PlayerLevel);
        Player.MaxHealth = CalculateNewStats(Player.PlayerClass.BaseHealth, Player.PlayerClass.MaxHealth, Player.PlayerLevel);
        Player.Health = Player.MaxHealth;
        Player.MaxMagic = CalculateNewStats(Player.PlayerClass.BaseMagic, Player.PlayerClass.MaxMagic, Player.PlayerLevel);
        Player.Magic = Player.MaxMagic;

        //Assigns the player a new experience required to reach the next level
        Player.RequiredExp = CalculateNewStats(minLevelExp, maxLevelExp, Player.PlayerLevel);
    }

    private static int CalculateNewStats(int min, int max, int current)
    {
        float c = max / min; ;
        float b = Mathf.Log(c) / (maxLevel - 1);
        float a = (min / Mathf.Exp(b));
        int newStat =(int)(a * Mathf.Exp(b * current));

        return newStat;
    }
}
