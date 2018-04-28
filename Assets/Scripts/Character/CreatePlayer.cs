using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour {
    private BasePlayer newPlayer;
    private string playerName = "Jack";
    private bool isHero;
    private bool isMusician;
    private bool isAcademic;
    private bool isAthlete;
	    // Use this for initialization
	    void Start () {
        newPlayer = new BasePlayer();
		
	    }
	
	    // Update is called once per frame
	    void Update () {
		
	    }
    private void OnGUI()
    {
        playerName = GUILayout.TextField(playerName,10);
        isHero = GUILayout.Toggle(isHero, "Hero");
        isMusician = GUILayout.Toggle(isMusician, "Musician");
        isAcademic = GUILayout.Toggle(isAcademic, "Academic");
        isAthlete = GUILayout.Toggle(isAthlete, "Athlete");
        if (GUILayout.Button("CREATE"))
        {
            if (isHero)
            {
                newPlayer.PlayerClass = new BaseHeroClass();

            }
            else if (isMusician)
            {
                newPlayer.PlayerClass = new BaseMusicianClass();
            }
            else if (isAcademic)
            {
                newPlayer.PlayerClass = new BaseAcademicClass();
            }
            else if (isAthlete)
            {
                newPlayer.PlayerClass = new BaseAthleteClass();
            }
            newPlayer.PlayerLevel = 1;
            newPlayer.PlayerName = playerName; 
            newPlayer.Attack = newPlayer.PlayerClass.Attack;
            newPlayer.Defence = newPlayer.PlayerClass.Defence;
            newPlayer.Health = newPlayer.PlayerClass.Health;
            newPlayer.Magic = newPlayer.PlayerClass.Magic;

            StoreNewPlayerInfo();
            SaveInformation.SaveAllInformation();

            Debug.Log("Name: " + newPlayer.PlayerName);
            Debug.Log("Player Class: " + newPlayer.PlayerClass.CharacterClassName);
            Debug.Log("Lv: " + newPlayer.PlayerLevel);
            Debug.Log("ATK: " + newPlayer.Attack);
            Debug.Log("DEF: " + newPlayer.Defence);
            Debug.Log("HP: " + newPlayer.Health +"/" + newPlayer.Health);
            Debug.Log("MP: " + newPlayer.Magic + "/" + newPlayer.Magic);
        }
        if (GUILayout.Button("LOAD"))
        {
            Application.LoadLevel("World");
        }
    }


    private void StoreNewPlayerInfo()
    {
        GameInformation.Player1Level = newPlayer.PlayerLevel;
        GameInformation.Attack1 = newPlayer.Attack;
        GameInformation.Defence1 = newPlayer.Defence;
        GameInformation.Health1 = newPlayer.Health;
        GameInformation.Magic1 = newPlayer.Magic;
    }
}
