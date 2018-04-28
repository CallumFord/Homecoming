using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseWeapon : BaseItem
{
    public enum WeaponTypes
    {
        Fist,
        Guitar,
        Tech,
        Bat
    }
    private WeaponTypes weaponType;
    private int weaponEffectID;

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value;}
    }
    public int WeaponEffectID
    {
        get { return weaponEffectID;}
        set { weaponEffectID = value;}
    }
}

