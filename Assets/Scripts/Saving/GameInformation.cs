using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInformation : MonoBehaviour {
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    //Whether or not Players 2, 3 and 4 are in the party
    public static int Player2 { get; set; }
    public static int Player3 { get; set; }
    public static int Player4 { get; set; }

    //How far the player is in the main story, effects the triggering of mutliple events
    public static int StoryProgress { get; set; }

    //The amount of money the player possesses, checked when attempting to make purchases
    public static int Money { get; set; }

    //The stats for Player 1
    public static string Player1Name { get; set; }
    public static int Player1Level { get; set; }
    public static int Player1Experience { get; set; }
    public static int Player1Required { get; set; }
    public static string Player1Class { get; set; }
    public static int Attack1 { get; set; }
    public static int Health1 { get; set; }
    public static int Magic1 { get; set; }
    public static int Defence1 { get; set; }
    public static BaseItem Equipment1Weapon { get; set; }
    public static BaseItem Equipment1Armour { get; set; }
    public static BaseItem Equipment1Accessory { get; set; }

    //The stats for Player 2
    public static string Player2Name { get; set; }
    public static int Player2Level { get; set; }
    public static int Player2Experience { get; set; }
    public static int Player2Required { get; set; }
    public static string Player2Class { get; set; }
    public static int Attack2 { get; set; }
    public static int Health2 { get; set; }
    public static int Magic2 { get; set; }
    public static int Defence2 { get; set; }
    public static BaseItem Equipment2Weapon { get; set; }
    public static BaseItem Equipment2Armour { get; set; }
    public static BaseItem Equipment2Accessory { get; set; }

    //The stats for Player 3
    public static string Player3Name { get; set; }
    public static int Player3Level { get; set; }
    public static int Player3Experience { get; set; }
    public static int Player3Required { get; set; }
    public static string Player3Class { get; set; }
    public static int Attack3 { get; set; }
    public static int Health3 { get; set; }
    public static int Magic3 { get; set; }
    public static int Defence3 { get; set; }
    public static BaseItem Equipment3Weapon { get; set; }
    public static BaseItem Equipment3Armour { get; set; }
    public static BaseItem Equipment3Accessory { get; set; }

    //The stats for Player 4
    public static string Player4Name { get; set; }
    public static int Player4Level { get; set; }
    public static int Player4Experience { get; set; }
    public static int Player4Required { get; set; }
    public static string Player4Class { get; set; }
    public static int Attack4 { get; set; }
    public static int Health4 { get; set; }
    public static int Magic4 { get; set; }
    public static int Defence4 { get; set; }
    public static BaseItem Equipment4Weapon { get; set; }
    public static BaseItem Equipment4Armour { get; set; }
    public static BaseItem Equipment4Accessory { get; set; }
}
