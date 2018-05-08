using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLeatherJacket : BaseArmour
{

    public BaseLeatherJacket()
    {
        ItemName = "Leather Jacket";
        ItemDescription = "A stylush leather jacket";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Armour;
        ArmourType = ArmourEnumerator.ArmourTypes.Jacket;
        Attack = 0;
        Defence = 10;
        Health = 0;
        Magic = 0;
    }
}
