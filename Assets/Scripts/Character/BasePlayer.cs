using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    //The defining characteristics of the player
    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;
    private int currentExp;
    private int requiredExp;

    //The stats of the player
    private int attack;
    private int defence;
    private int health;
    private int magic;

    //The maximum HP and MP of the player
    private int maxHealth;
    private int maxMagic;

    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value;}
    }
    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value; }
    }
    public int CurrentExp
    {
        get { return currentExp; }
        set { currentExp = value; }
    }
    public int RequiredExp
    {
        get { return requiredExp; }
        set {requiredExp = value; }
    }
    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
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
    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
    public int MaxMagic
    {
        get { return maxMagic; }
        set { maxMagic = value; }
    }
}
