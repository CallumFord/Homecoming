using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSequence
{
    //A list of notes to be played in sequence
    public static void CreateTestSequence()
    {
        GameInformation.NoteSequence.Add(CreateNote(DirectionEnumerator.NoteDirections.LEFT, TypeEnumerator.NoteTypes.BASIC, 2, 3, 1));
        GameInformation.NoteSequence.Add(CreateNote(DirectionEnumerator.NoteDirections.RIGHT, TypeEnumerator.NoteTypes.FIRE, 2, 3, 1));
        GameInformation.NoteSequence.Add(CreateNote(DirectionEnumerator.NoteDirections.UP, TypeEnumerator.NoteTypes.SHOCK, 2, 3, 1));
        GameInformation.NoteSequence.Add(CreateNote(DirectionEnumerator.NoteDirections.DOWN, TypeEnumerator.NoteTypes.POISON, 2, 3, 1));
    }

    //A function which creates notes and allocates them their individual properties. These will later be added to Sequence
    private static  BaseNote CreateNote(DirectionEnumerator.NoteDirections newDirection, TypeEnumerator.NoteTypes newType, int newSpeed, int newDamage, int newTarget)
    {
        BaseNote newNote = new BaseNote() { NoteDirection = newDirection, NoteType = newType, Speed = newSpeed, Damage = newDamage, Target = newTarget};
        return (newNote);
    } 
}


