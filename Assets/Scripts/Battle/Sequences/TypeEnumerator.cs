using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeEnumerator : MonoBehaviour {

    public enum NoteTypes //The possible types of notes
    {
        BASIC, //Standard note, no special properties
        FIRE, //Will temporarily prevent the player from playing subsequent notes, ensuring additional damage
        SHOCK, //Will damage all players, not just the targeted player
        POISON, //Will damage the player if played, will not damage the player if allowed to pass unplayed
        PHASE //Will change direction half-way to the player input region
    }
}
