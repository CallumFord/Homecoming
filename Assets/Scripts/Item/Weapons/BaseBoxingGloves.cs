using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseBoxingGloves : BaseWeapon {

    public BaseBoxingGloves()
    {
        ItemName = "Boxing Gloves";
        ItemDescription = "A Pair of Boxing Gloves";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Weapon;
        WeaponType = WeaponEnumerator.WeaponTypes.Fist;
        Attack = 10;
        Defence = 0;
        Health = 0;
        Magic = 0;
    }
}
