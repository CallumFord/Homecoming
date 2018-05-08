using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy {

    public string EnemyName { get; set; }  //The name of the enemy as it appears in-game
    public int Exp { get; set; } //The amount of experience given when the enemy is defeated  
    public int Money { get; set; } //The amount of money given when the enemy is defeated
    public BaseEnemyClass EnemyClass { get; set; } //The enemies class
    public int Attack { get; set; } //The attack of the enemy
    public int Defence { get; set; } //The defence of the enemy
    public int Health { get; set; } //The current hit points of the enemy
    public int Magic { get; set; } //The current magic points of the enemy
    public int MaxHealth { get; set; } //The maximum hit points of the enemy
    public int MaxMagic { get; set; } //The maximum magic points of the enemy
}
