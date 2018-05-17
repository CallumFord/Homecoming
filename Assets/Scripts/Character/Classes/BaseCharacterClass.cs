using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    public string CharacterClassName { get; set; } //The name of the characters class

    //Base stats for the class at level 1
    public int BaseAttack { get; set; }
    public int BaseDefence { get; set; }
    public int BaseHealth { get; set; }
    public int BaseMagic { get; set; }

    //Max stats for the class at level 100
    public int MaxAttack { get; set; }
    public int MaxDefence { get; set; }
    public int MaxHealth { get; set; }
    public int MaxMagic { get; set; }

    public BaseItem Weapon { get; set; } //The player's currently equipped weapon
    public BaseItem Armour { get; set; } //The player's currently equipped armour
    public BaseItem Accessory { get; set; } //The player's currently equipped accessory

    public string PortraitSprite { get; set; } //The sprite that represents the player's portrait in-battle
}

