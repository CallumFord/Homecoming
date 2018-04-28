using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMusicianClass : BaseCharacterClass {

    public BaseMusicianClass()
    {
        CharacterClassName = "Musician";
        Attack = 8;
        MaxAttack = 160;
        Defence = 8;
        MaxDefence = 160;
        Health = 15;
        MaxHealth = 300;
        Magic = 20;
        MaxMagic = 400;
    }
}
