using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame:MonoBehaviour
{

    public static void NewGameInformation()
    {

        //Creates instances of player objects in order to set up initial game 
        BasePlayer Player1 = new BasePlayer() {PlayerClass = new BaseHeroClass()} ;
        BasePlayer Player2 = new BasePlayer() { PlayerClass = new BaseMusicianClass() }; 
        BasePlayer Player3 = new BasePlayer() { PlayerClass = new BaseAcademicClass() };
        BasePlayer Player4 = new BasePlayer() { PlayerClass = new BaseAthleteClass() };

        //Sets initial story progress and money
        GameInformation.StoryProgress = 0;
        GameInformation.Money = 0;

        //Adds all players to the list of possible party members
        GameInformation.AddPlayer(Player1);
        GameInformation.AddPlayer(Player2);
        GameInformation.AddPlayer(Player3);
        GameInformation.AddPlayer(Player4);

        GameInformation.AddToParty(Player1); //Adds the player character to the party
    }
}
