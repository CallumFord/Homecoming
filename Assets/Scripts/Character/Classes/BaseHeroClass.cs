using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHeroClass : BaseCharacterClass
{
    public BaseHeroClass()
    {
        CharacterClassName = "Hero";
        BaseAttack = 10;
        MaxAttack = 200;
        BaseDefence = 10;
        MaxDefence = 200;
        BaseHealth = 20;
        MaxHealth = 400;
        BaseMagic = 5;
        MaxMagic = 100;

        Weapon = new BaseFist();
        Armour = new BaseTShirt();
        Accessory = new BaseLeatherBelt();
    }
}
