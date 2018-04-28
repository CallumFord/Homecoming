using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAthleteClass : BaseCharacterClass {

    public BaseAthleteClass()
    {
        CharacterClassName = "Athlete";
        Attack = 15;
        MaxAttack = 300;
        Defence = 12;
        MaxDefence = 240;
        Health = 25;
        MaxHealth = 500;
        Magic = 0;
        MaxMagic = 0;
    }
}
