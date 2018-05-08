using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySequence : BaseNote {

    //A list of notes to be played in sequence
    public void Start()
    {
        Debug.Log("BIG ASS ANIME TIDDIES");
        List<BaseNote> sequence = new List<BaseNote>();
        sequence.Add(CreateNote(DirectionEnumerator.NoteDirections.LEFT, TypeEnumerator.NoteTypes.BASIC, 2, 3, 1));
        sequence.Add(CreateNote(DirectionEnumerator.NoteDirections.RIGHT, TypeEnumerator.NoteTypes.FIRE, 2, 3, 1));
        sequence.Add(CreateNote(DirectionEnumerator.NoteDirections.UP, TypeEnumerator.NoteTypes.SHOCK, 2, 3, 1));
        sequence.Add(CreateNote(DirectionEnumerator.NoteDirections.DOWN, TypeEnumerator.NoteTypes.POISON, 2, 3, 1));
        StartCoroutine(CreateNoteSequence(sequence, 120));
    }

    //A function which creates notes and allocates them their individual properties. These will later be added to Sequence
    private BaseNote CreateNote(DirectionEnumerator.NoteDirections Direction, TypeEnumerator.NoteTypes Type, int Speed, int Damage, int Target)
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
            yield return new WaitForSeconds(1);
        }
    }

}