using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNote {

    public DirectionEnumerator.NoteDirections NoteDirection { get; set; } //Which key the player will have to press to hit this note
    public TypeEnumerator.NoteTypes NoteType { get; set; } //The type of this note
    public int Speed { get; set; }  //The speed of the note
    public int Damage { get; set; } //The base damage the note will inflict (Before target defence)
    public int Target { get; set; } //The targeted player
    public CircleCollider2D NoteCollision { get; set; } //The collider around the note that detects whether it is touching the key-pad for that column
    Sprite Sprite { get; set; } //The image used to represent the note in-game
}
