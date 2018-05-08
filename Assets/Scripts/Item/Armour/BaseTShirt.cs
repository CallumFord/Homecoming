using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseTShirt : BaseArmour {

    public BaseTShirt()
    {
        ItemName = "T-shirt";
        ItemDescription = "An Ordinary T-Shirt";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Armour;
        ArmourType = ArmourEnumerator.ArmourTypes.Shirt;
        Attack = 0;
        Defence = 5;
        Health = 0;
        Magic = 0;
    }
}
