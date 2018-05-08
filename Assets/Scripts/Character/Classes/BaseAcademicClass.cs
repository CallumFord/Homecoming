using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAcademicClass : BaseCharacterClass {

    public BaseAcademicClass()
    {
        CharacterClassName = "Academic";
        BaseAttack = 10;
        MaxAttack = 200;
        BaseDefence = 10;
        MaxDefence = 200;
        BaseHealth = 15;
        MaxHealth = 300;
        BaseMagic = 10;
        MaxMagic = 200;

        Weapon = new BaseFist();
        Armour = new BaseTShirt();
        Accessory = new BaseSimpleRing();
    }
}
