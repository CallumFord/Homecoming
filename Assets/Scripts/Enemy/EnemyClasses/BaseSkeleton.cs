using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkeleton : BaseEnemyClass {

    public BaseSkeleton()
    {
        EnemyName = "Skeleton";
        Exp = 5;
        Money = 5;

        Attack = 5;
        Defence = 5;
        Health = 10;
        Magic = 0;
    }
}
