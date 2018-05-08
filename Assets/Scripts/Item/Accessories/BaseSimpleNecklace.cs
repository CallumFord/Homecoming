using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSimpleNecklace : BaseAccessory {

    public BaseSimpleNecklace()
    {
        ItemName = "Simple Necklace";
        ItemDescription = "An ordinary simple Necklace";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Accessory;
        AccessoryType = AccessoryEnumerator.AccessoryTypes.Necklace;
        Attack = 2;
        Defence = 3;
        Health = 0;
        Magic = 0;
    }
}
