using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseNote : MonoBehaviour {

    public enum NoteColumns //The possible keys which the player can press to target notes
    {
        Left,
        Up,
        Down,
        Right
    }
    private NoteColumns noteColumn; //Which key the player will have to press to hit this note
    private int speed; //The speed of the note
    private int damage; //The base damage the note will inflict (Before target defence)
    private int target; //The targeted player
    private CircleCollider2D noteCollision; //The collider around the note that detects whether it is touching the key-pad for that column

    public NoteColumns NoteColumn
    {
        get { return noteColumn; }
        set { noteColumn = value; }
    }
    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public int Target
    {
        get { return target; }
        set { target = value; }
    }
    public CircleCollider2D NoteCollision
    {
        get { return noteCollision; }
        set { noteCollision = value; }
    }
}
