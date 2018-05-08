using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem
{
    public string ItemName { get; set; } //The name of the item as it appears in-game
    public string ItemDescription { get; set; } //The item's in-game description
    public int ItemID { get; set; } //Item ID (For inventory sorting)
    public ItemEnumerator.ItemTypes ItemType { get; set; } //The type of item

    //The stat increases when item is equipped (Or used in the case of consumables)
    public int Attack { get; set; } //The name of the item as it appears in-game
    public int Defence { get; set; }
    public int Health { get; set; }
    public int Magic { get; set; }

    public int Price { get; set; } //Item value for buying/selling
}
