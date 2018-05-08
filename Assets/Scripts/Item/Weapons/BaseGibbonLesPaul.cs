using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseGibbonLesPaul : BaseWeapon {

    public BaseGibbonLesPaul()
    {
        ItemName = "Gibbon Les Paul";
        ItemDescription = "Good for a bit of monkeying around";
        ItemID = 11;
        ItemType = ItemEnumerator.ItemTypes.Weapon;
        WeaponType = WeaponEnumerator.WeaponTypes.Guitar;
        Attack = 7;
        Defence = 0;
        Health = 0;
        Magic = 5;
    }
}
