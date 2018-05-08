using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAthleteClass : BaseCharacterClass {

    public BaseAthleteClass()
    {
        CharacterClassName = "Athlete";
        BaseAttack = 15;
        MaxAttack = 300;
        BaseDefence = 12;
        MaxDefence = 240;
        BaseHealth = 25;
        MaxHealth = 500;
        BaseMagic = 0;
        MaxMagic = 0;

        Weapon = new BaseBaseballBat();
        Armour = new VarsityJacket();
        Accessory = new BaseSimpleNecklace();
    }
}
