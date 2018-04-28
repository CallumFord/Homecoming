using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp {

    //Maximum Character Level and the experience required to achieve
    private static int maxLevel = 100;
    private static int minLevelExp = 20;
    private static int maxLevelExp = 40000;

    public static void LevelUpCharacter(BaseCharacterClass  Class, int level)
    {
        level += 1;
        GameInformation.Player1Level = level;
        AssignNewStats(Class, level);
    }

    private static void AssignNewStats(BaseCharacterClass Class, int level)
    {
        //Assigns the player new stats by interpolating between their minimum and maximum values appropriately for their current level 
        GameInformation.Attack1 = CalculateNewStats(Class.Attack, Class.MaxAttack, level);
        GameInformation.Defence1 = CalculateNewStats(Class.Defence, Class.MaxDefence, level);
        GameInformation.Magic1 = CalculateNewStats(Class.Magic, Class.MaxMagic, level);
        GameInformation.Health1 = CalculateNewStats(Class.Health, Class.MaxHealth, level);

        //Assigns the player a new experience required to reach the next level
        GameInformation.Player1Required = CalculateNewStats(minLevelExp, maxLevelExp, level);
    }

    private static int CalculateNewStats(int min, int max, int position)
    {
        //Exponential plotting function for new stats
        float x = Mathf.Log(max / min);
        float b = x / (maxLevel - 1);
        float y = (Mathf.Exp(b) - 1);
        float a = min / y;
        int newStat = (int)(a * Mathf.Exp(((float)b * position)));
        newStat = (int)Mathf.Round((float)newStat / 10.0f) * 10;
        return newStat;
    }
}
