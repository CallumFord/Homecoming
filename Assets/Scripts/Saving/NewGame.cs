using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGame
{

    public static void NewGameInformation()
    {
        //Creates instances of player objects in order to set up initial game information
        BasePlayer Player1 = new BasePlayer();
        BasePlayer Player2 = new BasePlayer();
        BasePlayer Player3 = new BasePlayer();
        BasePlayer Player4 = new BasePlayer();

        Player1.PlayerClass = new BaseHeroClass();
        Player2.PlayerClass = new BaseMusicianClass();
        Player3.PlayerClass = new BaseAcademicClass();
        Player4.PlayerClass = new BaseAthleteClass();

        Player1.CurrentExp = 0;
        Player2.CurrentExp = 0;
        Player3.CurrentExp = 0;
        Player4.CurrentExp = 0;

        //Sets initial story progress and money
        GameInformation.StoryProgress = 0;
        GameInformation.Money = 0;

        //Sets base stats and starting equipment for player 1
        GameInformation.Player1Name = "";
        GameInformation.Player1Level = 1;
        GameInformation.Player1Experience = 0;
        GameInformation.Player1Required = 20;
        GameInformation.Attack1 = Player1.PlayerClass.Attack;
        GameInformation.Defence1 = Player1.PlayerClass.Defence;
        GameInformation.Health1 = Player1.PlayerClass.Health;
        GameInformation.Magic1 = Player1.PlayerClass.Magic;
        GameInformation.Equipment1Weapon = new BaseFist();
        GameInformation.Equipment1Armour = new BaseFist();
        GameInformation.Equipment1Accessory = new BaseFist();

        //Sets base stats and starting equipment for player 2
        GameInformation.Player2Name = "Eric";
        GameInformation.Player2Level = 1;
        GameInformation.Player2Required = 20;
        GameInformation.Player2Experience = 0;
        GameInformation.Attack2 = Player2.PlayerClass.Attack;
        GameInformation.Defence2 = Player2.PlayerClass.Defence;
        GameInformation.Health2 = Player2.PlayerClass.Health;
        GameInformation.Magic2 = Player2.PlayerClass.Magic;
        GameInformation.Equipment2Weapon = new BaseGibbonLesPaul();
        GameInformation.Equipment2Armour = null;
        GameInformation.Equipment2Accessory = null;

        //Sets base stats and starting equipment for player 3
        GameInformation.Player3Name = "Dean";
        GameInformation.Player3Level = 1;
        GameInformation.Player3Experience = 0;
        GameInformation.Player3Required = 20;
        GameInformation.Attack3 = Player3.PlayerClass.Attack;
        GameInformation.Defence3 = Player3.PlayerClass.Defence;
        GameInformation.Health3 = Player3.PlayerClass.Health;
        GameInformation.Magic3 = Player3.PlayerClass.Magic;
        GameInformation.Equipment3Weapon = new BaseFist();
        GameInformation.Equipment3Armour = null;
        GameInformation.Equipment3Accessory = null;

        //Sets base stats and starting equipment for player 4
        GameInformation.Player4Name = "Nathan";
        GameInformation.Player4Level = 1;
        GameInformation.Player4Experience = 0;
        GameInformation.Player4Required = 20;
        GameInformation.Attack4 = Player4.PlayerClass.Attack;
        GameInformation.Defence4 = Player4.PlayerClass.Defence;
        GameInformation.Health4 = Player4.PlayerClass.Health;
        GameInformation.Magic4 = Player4.PlayerClass.Magic;
        GameInformation.Equipment4Weapon = new BaseBaseballBat();
        GameInformation.Equipment4Armour = null;
        GameInformation.Equipment4Accessory = null;
    }

}
