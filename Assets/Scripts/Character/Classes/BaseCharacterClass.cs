using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacterClass
{
    private string characterClassName; //The name of the characters class
    //Base stats for the class
    private int attack;
    private int defence;
    private int health;
    private int magic;

    //Stats for the class at max level
    private int maxAttack;
    private int maxDefence;
    private int maxHealth;
    private int maxMagic;

    public string CharacterClassName
    {
        get { return characterClassName; }
        set { characterClassName = value; }
    }
    public int Attack
    {
        get { return attack; }
        set { attack = value; }
    }
    public int MaxAttack
    {
        get { return maxAttack; }
        set { maxAttack = value; }
    }
    public int Defence
    {
        get { return defence; }
        set { defence = value; }
    }
    public int MaxDefence
    {
        get { return maxDefence; }
        set { maxDefence = value; }
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
    public int Magic
    {
        get { return magic; }
        set { magic = value; }
    }
    public int MaxMagic
    {
        get { return maxMagic; }
        set { maxMagic = value; }
    }
}

