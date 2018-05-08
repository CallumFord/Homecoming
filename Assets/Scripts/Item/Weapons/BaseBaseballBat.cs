using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseBaseballBat : BaseWeapon
{
    public BaseBaseballBat()
    {
        ItemName = "Baseball Bat";
        ItemDescription = "A Baseball Bat";
        ItemID = 5;
        ItemType = ItemEnumerator.ItemTypes.Weapon;
        WeaponType = WeaponEnumerator.WeaponTypes.Bat;
        Attack = 20;
        Defence = 5;
        Health = 0;
        Magic = 0;
    }
}
