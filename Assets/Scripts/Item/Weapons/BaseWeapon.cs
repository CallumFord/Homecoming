using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon : BaseItem
{

    public WeaponEnumerator.WeaponTypes WeaponType { get; set; } //The type of weapon
    public int WeaponEffectID { get; set; }  //The additional effect of the weapon
}

