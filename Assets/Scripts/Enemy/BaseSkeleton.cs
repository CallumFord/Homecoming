using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSkeleton : BaseEnemy {

    public BaseSkeleton()
    {
        EnemyName = "Skeleton";
        Exp = 5;
        Money = 5;

        Attack = 5;
        Defence = 5;
        MaxHealth = 10;
        MaxMagic = 0;
        Health = MaxHealth;
        Magic = MaxMagic;

        Sprite = "SKELETON";
    }
}
