using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseFist : BaseWeapon {

    public BaseFist()
    {
        ItemName = "Fist";
        ItemDescription = "An ordinary pair of fists";
        ItemID = 1;
        ItemType = ItemEnumerator.ItemTypes.Weapon;
        WeaponType = WeaponEnumerator.WeaponTypes.Fist;
        Attack = 5;
        Defence = 0;
        Health = 0;
        Magic = 0;
    }
}
