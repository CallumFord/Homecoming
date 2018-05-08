using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    public string CharacterClassName { get; set; } //The name of the characters class

    //Base stats for the class at level 1
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int Health { get; set; }
    public int Magic { get; set; }

    //Max stats for the class at level 100
    public int MaxAttack { get; set; }
    public int MaxDefence { get; set; }
    public int MaxHealth { get; set; }
    public int MaxMagic { get; set; }
}

