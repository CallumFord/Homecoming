using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBattle {

    private  BaseEnemy Enemy1 = new BaseEnemy();
    private  BaseEnemy Enemy2 = new BaseEnemy();
    private  BaseEnemy Enemy3 = new BaseEnemy();

    //Transitions the game the the battle scene and loads the relevent enemy data
    public void BattleStart(BaseEnemyClass EnemyClass1, BaseEnemyClass EnemyClass2, BaseEnemyClass EnemyClass3)
    {
        CreateNewEnemy(EnemyClass1, Enemy1);
        if (EnemyClass2 != null)
        {
            CreateNewEnemy(EnemyClass2, Enemy2);
        }
        if (EnemyClass3 != null)
        {
            CreateNewEnemy(EnemyClass3, Enemy3);
        }
    }

    private void CreateNewEnemy(BaseEnemyClass EnemyClass, BaseEnemy Enemy)
    {
        Enemy.EnemyName = EnemyClass.EnemyName;
        Enemy.EnemyClass = EnemyClass;
    }
}
