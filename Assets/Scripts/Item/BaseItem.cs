using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseItem
{
    private string itemName; //The name of the item as it appears in-game
    private string itemDescription; //The item's in-game description
    private int itemID; //Item ID (For inventory sorting)

    public enum ItemTypes
    {
        Weapon,
        Armour,
        Accessory,
        Consumable,
        Quest
    }
    private ItemTypes itemType; //The type of item

    //The stat increases when item is equipped (Or used in the case of consumables)
    private int attack;
    private int defence;
    private int health;
    private int magic;

    private int price; //Item value for buying/selling

    public string ItemName
    {
        get{ return itemName;}
        set { itemName = value; }
    }
    public string ItemDescription
    {
        get { return itemDescription; }
        set { itemDescription = value;}
    }
    public int ItemID
    {
        get { return itemID; }
        set { itemID = value;}
    } 
    public ItemTypes ItemType
    {
        get { return itemType; }
        set { itemType = value; }
    }

    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int Defence
    {
        get { return defence; }
        set { defence = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
}
