using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseAccessory : BaseItem {

    public AccessoryEnumerator.AccessoryTypes AccessoryType { get; set; } //The type of Armour
    public int AccessoryEffectID { get; set; } //The additional effect of your armour
}
