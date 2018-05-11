using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBattle:MonoBehaviour {


    //Transitions the game the the battle scene and loads the relevent enemy data
    public static void BattleStart(List<BaseEnemy> Enemies)
    {
        foreach (BaseEnemy NewEnemy in Enemies)
        {
            GameObject Enemy = (GameObject)Instantiate(Resources.Load(NewEnemy.Sprite), new Vector3(0, 0, 0), new Quaternion());
        }

    }
}
