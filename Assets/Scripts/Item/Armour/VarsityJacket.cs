using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarsityJacket : BaseArmour
{

    public VarsityJacket()
    {
        ItemName = "Varsity Jacket";
        ItemDescription = "A cool Varsity Jacket";
        ItemID = 2;
        ItemType = ItemEnumerator.ItemTypes.Armour;
        ArmourType = ArmourEnumerator.ArmourTypes.Shirt;
        Attack = 5;
        Defence = 8;
        Health = 0;
        Magic = 0;
    }
}