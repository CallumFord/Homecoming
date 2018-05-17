using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMusicianClass : BaseCharacterClass {

    public BaseMusicianClass()
    {
        CharacterClassName = "Musician";
        BaseAttack = 8;
        MaxAttack = 160;
        BaseDefence = 8;
        MaxDefence = 160;
        BaseHealth = 15;
        MaxHealth = 300;
        BaseMagic = 20;
        MaxMagic = 400;

        Weapon = new BaseGibbonLesPaul();
        Armour = new BaseLeatherJacket();
        Accessory = new BaseSimpleRing();

        PortraitSprite = "Player_Portrait";
    }
}
