using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSequence : BaseNote
{
    //A list of notes to be played in sequence
    public static void CreateTestSequence()
    {
        List<BaseNote> sequence = new List<BaseNote>();
        sequence.Add(CreateNote(NoteColumns.LEFT, 2, 3, 1));
        sequence.Add(CreateNote(NoteColumns.RIGHT, 2, 3, 1));
        sequence.Add(CreateNote(NoteColumns.UP, 2, 3, 1));
        sequence.Add(CreateNote(NoteColumns.DOWN, 2, 3, 1));
        CreateNoteSequence(sequence, 120);
    }

    //A function which creates notes and allocates them their individual properties. These will later be added to Sequence
    private static BaseNote CreateNote(NoteColumns Direction, int Speed, int Damage, int Target)
    {
        BaseNote newNote = new BaseNote();
        newNote.NoteColumn = Direction;
        newNote.Speed = Speed;
        newNote.Damage = Damage;
        newNote.Target = Target;
        return (newNote);
    }

    //Generates each note in Sequence at intervals specified by the bpm of the sequence
    private static void CreateNoteSequence(List<BaseNote> Sequence, int bpm)
    {
        float noteSpacing = (bpm / 60);
        foreach (BaseNote Note in Sequence)
        {
            //Creates a GameObject to represent the note and assigns the properties of the note to the object
            int xpos = new int();
            switch (Note.NoteColumn)
            {
                case (NoteColumns.LEFT):
                    {
                        xpos = -3;
                        break;
                    }
                case (NoteColumns.UP):
                    {
                        xpos = -1;
                        break;
                    }
                case (NoteColumns.DOWN):
                    {
                        xpos = +1;
                        break;
                    }
                case (NoteColumns.RIGHT):
                    {
                        xpos = +3;
                        break;
                    }
            }
            Vector3 position = new Vector3(xpos, +1f, 0);

            Debug.Log("NOTE");
            GameObject newNote = (GameObject)Instantiate(Resources.Load("bbbbbb 1"), position, new Quaternion());
        }
    }
}


