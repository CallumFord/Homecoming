using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    public string PlayerName { get; set; } //Name of the character as it appears in-game
    public int PlayerLevel { get; set; } //The level of the player
    public int CurrentExp { get; set; } //The player's current experience
    public int RequiredExp { get; set; } //The experience of the player required for the next level up
    public BaseCharacterClass PlayerClass { get; set; } //The class of the character
    public int Attack { get; set; } //The attack of the player
    public int Defence { get; set; } //The defence of the player
    public int Health { get; set; } //The player's current hit points
    public int Magic { get; set; } //The player's current magic points
    public int MaxHealth { get; set; } //The player's maximum hit points
    public int MaxMagic { get; set; } //The player's maximum magic points
    public BaseItem Weapon { get; set; } //The player's currently equipped weapon
    public BaseItem Armour { get; set; } //The player's currently equipped armour
    public BaseItem Accessory { get; set; } //The player's currently equipped accessory
}
