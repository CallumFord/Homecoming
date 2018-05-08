using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLeatherBelt : BaseAccessory
{
    public BaseLeatherBelt()
    {
        ItemName = "Leather Belt";
        ItemDescription = "An ordinary leather belt";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Accessory;
        AccessoryType = AccessoryEnumerator.AccessoryTypes.Belt;
        Attack = 0;
        Defence = 5;
        Health = 0;
        Magic = 0;
    }

}
