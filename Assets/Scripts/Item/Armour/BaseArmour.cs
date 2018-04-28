using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseArmour : BaseItem
{
    public enum ArmourTypes
    {
        Shirt,
        Jacket

    }
    private ArmourTypes armourType;
    private int armourEffectID;

    public ArmourTypes ArmourType
    {
        get { return armourType; }
        set { armourType = value; }
    }
    public int WeaponEffectID
    {
        get { return armourEffectID; }
        set { armourEffectID = value; }
    }
}

