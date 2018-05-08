using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSimpleRing : BaseAccessory {

    public BaseSimpleRing()
    {
        ItemName = "Simple Ring";
        ItemDescription = "An ordinary simple ring";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Accessory;
        AccessoryType = AccessoryEnumerator.AccessoryTypes.Ring;
        Attack = 0;
        Defence = 2;
        Health = 0;
        Magic = 3;
    }
}
