using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBasedBattle : MonoBehaviour
{
    private BattleEnumerator.Battle currentState; //The current state of the battle

    // Use this for initialization
    void Start()
    {
        currentState = BattleEnumerator.Battle.Start;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case (BattleEnumerator.Battle.Start):

                CreatePlayerDisplay.CreatePlayer(); //Creates the in-battle displays to represent the party
                CreatePlayerDisplay.CreateEnemy(); //Creates the sprites to represent the enemies
                CreateSequence.CreateTestSequence(); //Creates a test-sequence of notes to troubleshoot note generation
                PlaySequence Sequence = gameObject.AddComponent<PlaySequence>() as PlaySequence; //Plays the test-sequence of notes
                currentState = BattleEnumerator.Battle.PlayerTurn;
                break;
            case (BattleEnumerator.Battle.PlayerTurn):
                foreach (BasePlayer Player in GameInformation.PartyList)
                {
                //Provide the player with a menu of battle commands
                //Execute player attack
                //Check if enemy is defeated and if so, remove them from EnemyList
                //If EnemyList is empty, the player wins
                }
                //Change to enemy turn
                break;
            case (BattleEnumerator.Battle.EnemyTurn):
                //Generate sequence of notes for the enemies
                //Check if all players are defeated and if so, the player loses
                //Change to player turn
                break;
            case (BattleEnumerator.Battle.Win):
                //Provide party with Exp and Money
                //Return to World
                break;
            case (BattleEnumerator.Battle.Lose):
                //Return player to most recent check-point
                break;
        }

    }
}
