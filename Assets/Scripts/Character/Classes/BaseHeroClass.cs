using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHeroClass : BaseCharacterClass
{
    public BaseHeroClass()
    {
        CharacterClassName = "Hero";
        Attack = 10;
        MaxAttack = 200;
        Defence = 10;
        MaxDefence = 200;
        Health = 20;
        MaxHealth = 400;
        Magic = 5;
        MaxMagic = 100;
    }
}
