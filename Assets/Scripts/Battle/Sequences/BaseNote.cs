using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNote : MonoBehaviour {

    public enum NoteDirections //The possible keys which the player can press to target notes
    {
        LEFT,
        UP,
        DOWN,
        RIGHT
    }
    
    public enum NoteTypes //The possible types of notes
    {
        BASIC, //Standard note, no special properties
        FIRE, //Will temporarily prevent the player from playing subsequent notes, ensuring additional damage
        SHOCK, //Will damage all players, not just the targeted player
        POISON, //Will damage the player if played, will not damage the player if allowed to pass unplayed
        PHASE //Will change direction half-way to the player input region
    }

    public NoteDirections NoteDirection { get; set; } //Which key the player will have to press to hit this note
    public NoteTypes NoteType { get; set; } //The type of this note
    public int Speed { get; set; }  //The speed of the note
    public int Damage { get; set; } //The base damage the note will inflict (Before target defence)
    public int Target { get; set; } //The targeted player
    public CircleCollider2D NoteCollision { get; set; } //The collider around the note that detects whether it is touching the key-pad for that column
    Sprite Sprite { get; set; } //The image used to represent the note in-game
}
