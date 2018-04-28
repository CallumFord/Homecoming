using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy {

    private string enemyName;
    private int exp;
    private int money;
    private BaseEnemyClass enemyClass;


    private int attack;
    private int defence;
    private int health;
    private int magic;

    public string EnemyName
    {
        get { return enemyName; }
        set { enemyName = value; }
    }
    public int Exp
    {
        get { return exp; }
        set { exp = value; }
    }
    public int Money
    {
        get { return money; }
        set { money = value; }
    }
    public BaseEnemyClass EnemyClass
    {
        get { return enemyClass; }
        set { enemyClass = value; }
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
}
