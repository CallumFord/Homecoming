using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static List<BasePlayer> PlayerList = new List<BasePlayer>(); //The list of player objects
    public static List<BasePlayer> PartyList = new List<BasePlayer>();  //The list of player objects currenty in the party
    public static List<BaseEnemy> EnemiesList = new List<BaseEnemy>();  //The list of enemy objects for the current battle
    public static List<BaseNote> NoteSequence = new List<BaseNote>(); //The list of notes to be played in the current sequence

    public static int StoryProgress { get; set; } //How far the player is in the main story, effects the triggering of mutliple events
    public static int Money { get; set; }         //The amount of money the player possesses, checked when attempting to make purchases
    public static bool BattleStart { get; set;}   //Set when the enemies for the current battle have been added to the list of enemies, prevents duplicating enemies

    public static void AddPlayer(BasePlayer newPlayer) //Adds a new player to the list of player objects
    {
        PlayerList.Add(newPlayer);
    }
    public static void AddToParty(BasePlayer newPartyMember) //Adds a player to the list of players currently in the party
    {
        PartyList.Add(newPartyMember);
    }
    public static void RemoveFromParty(BasePlayer oldPartyMember) //Removes a player from the list of players currently in the party
    {
        PartyList.Remove(oldPartyMember);
    }
}
