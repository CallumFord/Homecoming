using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySequence : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		StartCoroutine("PlayNoteSequence");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private IEnumerator PlayNoteSequence()
    {
        int bpm = 60;
        float noteSpacing = (60 / bpm); 
        foreach (BaseNote Note in GameInformation.NoteSequence)
        {

            int xpos = new int(); //Assigns a starting x position for the note based on its direction
            switch (Note.NoteDirection)
            {
                case (DirectionEnumerator.NoteDirections.LEFT):
                    {
                        xpos = -3;
                        break;
                    }
                case (DirectionEnumerator.NoteDirections.UP):
                    {
                        xpos = -1;
                        break;
                    }
                case (DirectionEnumerator.NoteDirections.DOWN):
                    {
                        xpos = +1;
                        break;
                    }
                case (DirectionEnumerator.NoteDirections.RIGHT):
                    {
                        xpos = +3;
                        break;
                    }
            }

            string type = ""; //Assigns a representative type to the note based on its type
            switch (Note.NoteType)
            {
                case (TypeEnumerator.NoteTypes.BASIC):
                    {
                        type = "Note_Basic";
                        break;
                    }
                case (TypeEnumerator.NoteTypes.FIRE):
                    {
                        type = "Note_Fire";
                        break;
                    }
                case (TypeEnumerator.NoteTypes.SHOCK):
                    {
                        type = "Note_Shock";
                        break;
                    }
                case (TypeEnumerator.NoteTypes.POISON):
                    {
                        type = "Note_Poison";
                        break;
                    }
                case (TypeEnumerator.NoteTypes.PHASE):
                    {
                        type = "Note_Phase";
                        break;
                    }
            }
            Vector3 position = new Vector2(xpos, +1f);

            GameObject newNote = new GameObject("Note"); //Creates a game object named "Note" to represent the NOte

            SpriteRenderer noteSpriteRenderer = newNote.AddComponent<SpriteRenderer>(); //Adds a sprite renderer to the note
            noteSpriteRenderer.sprite = Resources.Load<Sprite>(type); //Assigns the note a sprite based on it's type
            noteSpriteRenderer.sortingLayerName = "Foreground"; //Moves the note sprite to the background

            Rigidbody2D noteRigidBody = newNote.AddComponent<Rigidbody2D>(); //Adds a rigid body 2D component to the note
            noteRigidBody.simulated = true; //Simulates motion of the note, enabling gravity and collisions

            CircleCollider2D noteCollider = newNote.AddComponent<CircleCollider2D>(); //Adds a collider to the note

            newNote.AddComponent<NoteCollision>(); //Adds the NoteCollision.cs script to handle collisions

            newNote.transform.position = position; //Moves the note to it's starting position

            yield return new WaitForSeconds(1f); //The delay before running the Coroutine again for the next note
        }
    }
}
