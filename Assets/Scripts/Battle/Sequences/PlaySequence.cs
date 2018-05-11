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
            Vector3 position = new Vector3(xpos, +1f, 0);
            GameObject newNote = (GameObject)Instantiate(Resources.Load(type), position, new Quaternion());
            yield return new WaitForSeconds(noteSpacing);
        }
    }
}
