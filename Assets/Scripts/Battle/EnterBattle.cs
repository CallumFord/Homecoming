using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBattle {

    private  BaseEnemy Enemy1 = new BaseEnemy();

    //Transitions the game the the battle scene and loads the relevent enemy data
    public void BattleStart(List<BaseEnemyClass> Enemies)
    {
        foreach(BaseEnemyClass Enemy in Enemies)
        {
            CreateNewEnemy(Enemy);
        }
        Application.LoadLevel("Battle");
    }

    private void CreateNewEnemy(BaseEnemyClass EnemyClass)
    {
        Enemy1.EnemyName = EnemyClass.EnemyName;
        Enemy1.EnemyClass = EnemyClass;
    }
}
