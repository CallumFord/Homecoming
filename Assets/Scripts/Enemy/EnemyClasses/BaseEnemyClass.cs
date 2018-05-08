using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemyClass
{
    public string EnemyName { get; set; } //The name of the enemy as it appears in-game
    public int Exp { get; set; } //The amount of exp the enemy rewards the player when defeated
    public int Money { get; set; } //The amount of money the enemy rewards the player when defeated
    
    //Enemy stats
    public int Attack { get; set; }
    public int Defence { get; set; }
    public int Health { get; set; }
    public int Magic { get; set; }
}
