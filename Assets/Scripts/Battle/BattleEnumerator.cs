using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnumerator
{
    public enum Battle //The possible states of the battle
    {
        Start,
        PlayerTurn,
        EnemyTurn,
        Lose,
        Win
    }
}
