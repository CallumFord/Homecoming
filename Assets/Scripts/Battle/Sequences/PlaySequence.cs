using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySequence : BaseNote {

    //A list of notes to be played in sequence
    public void Start()
    {
        Debug.Log("BIG ASS ANIME TIDDIES");
        List<BaseNote> sequence = new List<BaseNote>();
        sequence.Add(CreateNote(NoteDirections.LEFT, NoteTypes.BASIC, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.RIGHT, NoteTypes.FIRE, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.UP, NoteTypes.SHOCK, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.DOWN, NoteTypes.POISON, 2, 3, 1));
        StartCoroutine(CreateNoteSequence(sequence, 120));
    }

    //A function which creates notes and allocates them their individual properties. These will later be added to Sequence
    private BaseNote CreateNote(NoteDirections Direction, NoteTypes Type, int Speed, int Damage, int Target)
    {
        BaseNote newNote = new BaseNote();
        newNote.NoteDirection = Direction;
        newNote.NoteType = Type;
        newNote.Speed = Speed;
        newNote.Damage = Damage;
        newNote.Target = Target;
        return (newNote);
    }

    //Generates each note in Sequence at intervals specified by the bpm of the sequence
    private IEnumerator CreateNoteSequence(List<BaseNote> Sequence, int bpm)
    {
        Debug.Log("THICC GOTH GF");
        float noteSpacing = (bpm / 60); //
        foreach (BaseNote Note in Sequence)
        {

            int xpos = new int(); //Assigns a starting x position for the note based on its direction
            switch (Note.NoteDirection)
            {
                case (NoteDirections.LEFT):
                    {
                        xpos = -3;
                        break;
                    }
                case (NoteDirections.UP):
                    {
                        xpos = -1;
                        break;
                    }
                case (NoteDirections.DOWN):
                    {
                        xpos = +1;
                        break;
                    }
                case (NoteDirections.RIGHT):
                    {
                        xpos = +3;
                        break;
                    }
            }

            string type = ""; //Assigns a representative type to the note based on its type
            switch (Note.NoteType)
            {
                case (NoteTypes.BASIC):
                    {
                        type = "Note_Basic";
                        break;
                    }
                case (NoteTypes.FIRE):
                    {
                        type = "Note_Fire";
                        break;
                    }
                case (NoteTypes.SHOCK):
                    {
                        type = "Note_Shock";
                        break;
                    }
                case (NoteTypes.POISON):
                    {
                        type = "Note_Poison";
                        break;
                    }
                case (NoteTypes.PHASE):
                    {
                        type = "Note_Phase";
                        break;
                    }
            }
            Vector3 position = new Vector3(xpos, +1f, 0);
            GameObject newNote = (GameObject)Instantiate(Resources.Load(type), position, new Quaternion());
            yield return new WaitForSeconds(1);
        }
    }

}