using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCollision:MonoBehaviour {

    //Handles note collision
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "NoteBoard")
        {
            //Damage the player and remove the note from play
        }
    }
}
