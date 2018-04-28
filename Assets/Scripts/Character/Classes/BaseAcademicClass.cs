using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAcademicClass : BaseCharacterClass {

    public BaseAcademicClass()
    {
        CharacterClassName = "Academic";
        Attack = 10;
        MaxAttack = 200;
        Defence = 10;
        MaxDefence = 200;
        Health = 15;
        MaxHealth = 300;
        Magic = 10;
        MaxMagic = 200;
    }
}
