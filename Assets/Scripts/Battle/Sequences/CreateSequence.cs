using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSequence : BaseNote
{
    //A list of notes to be played in sequence
    public static void CreateTestSequence()
    {
        List<BaseNote> sequence = new List<BaseNote>();
        sequence.Add(CreateNote(NoteDirections.LEFT, NoteTypes.BASIC, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.RIGHT, NoteTypes.FIRE, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.UP, NoteTypes.SHOCK, 2, 3, 1));
        sequence.Add(CreateNote(NoteDirections.DOWN, NoteTypes.POISON, 2, 3, 1));
        CreateNoteSequence(sequence, 120);
    }

    //A function which creates notes and allocates them their individual properties. These will later be added to Sequence
    private static  BaseNote CreateNote(NoteDirections Direction, NoteTypes Type, int Speed, int Damage, int Target)
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
    private static void CreateNoteSequence(List<BaseNote> Sequence, int bpm)
    {
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
            switch(Note.NoteType)
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
        }
    }
   
}


