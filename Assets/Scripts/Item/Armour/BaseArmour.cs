using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseArmour : BaseItem
{
    public ArmourEnumerator.ArmourTypes ArmourType { get; set; } //The type of Armour
    public int WeaponEffectID { get; set; } //The additional effect of your armour
}

