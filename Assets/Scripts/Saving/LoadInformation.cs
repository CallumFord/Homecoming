using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInformation() //This function is called when the player loads their game file, overwrites game information with stored values
    {
        GameInformation.Player2 = PlayerPrefs.GetInt("PLAYER2");
        GameInformation.Player3 = PlayerPrefs.GetInt("PLAYER3");
        GameInformation.Player4 = PlayerPrefs.GetInt("PLAYER4");

        GameInformation.StoryProgress = PlayerPrefs.GetInt("PROGRESS");
        GameInformation.Money = PlayerPrefs.GetInt("MONEY");

        GameInformation.Player1Level = PlayerPrefs.GetInt("PLAYER1LEVEL");
        GameInformation.Player1Experience = PlayerPrefs.GetInt("PLAYER1EXP");
        GameInformation.Player1Class = PlayerPrefs.GetString("PLAYER1CLASS");
        GameInformation.Attack1 = PlayerPrefs.GetInt("ATTACK1");
        GameInformation.Defence1 = PlayerPrefs.GetInt("DEFENCE1");
        GameInformation.Health1 = PlayerPrefs.GetInt("HEALTH1");
        GameInformation.Magic1 = PlayerPrefs.GetInt("MAGIC1");

        GameInformation.Player2Level = PlayerPrefs.GetInt("PLAYER2LEVEL");
        GameInformation.Player2Experience = PlayerPrefs.GetInt("PLAYER2EXP");
        GameInformation.Player2Class = PlayerPrefs.GetString("PLAYER2CLASS");
        GameInformation.Attack2 = PlayerPrefs.GetInt("ATTACK2");
        GameInformation.Defence2 = PlayerPrefs.GetInt("DEFENCE2");
        GameInformation.Health2 = PlayerPrefs.GetInt("HEALTH2");
        GameInformation.Magic2 = PlayerPrefs.GetInt("MAGIC2");

        GameInformation.Player3Level = PlayerPrefs.GetInt("PLAYER3LEVEL");
        GameInformation.Player3Experience = PlayerPrefs.GetInt("PLAYER3EXP");
        GameInformation.Player3Class = PlayerPrefs.GetString("PLAYER3CLASS");
        GameInformation.Attack3 = PlayerPrefs.GetInt("ATTACK3");
        GameInformation.Defence3 = PlayerPrefs.GetInt("DEFENCE3");
        GameInformation.Health3 = PlayerPrefs.GetInt("HEALTH3");
        GameInformation.Magic3 = PlayerPrefs.GetInt("MAGIC3");

        GameInformation.Player4Level = PlayerPrefs.GetInt("PLAYER4LEVEL");
        GameInformation.Player4Experience = PlayerPrefs.GetInt("PLAYER4EXP");
        GameInformation.Player4Class = PlayerPrefs.GetString("PLAYER4CLASS");
        GameInformation.Attack4 = PlayerPrefs.GetInt("ATTACK4");
        GameInformation.Defence4 = PlayerPrefs.GetInt("DEFENCE4");
        GameInformation.Health4 = PlayerPrefs.GetInt("HEALTH4");
        GameInformation.Magic4 = PlayerPrefs.GetInt("MAGIC4");

        if (PlayerPrefs.GetString("EQUIPMENT1WEAPON") != null)
        {
            GameInformation.Equipment1Weapon = (BaseItem)PPSerialization.Load("EQUIPMENT1WEAPON");
        }
        if (PlayerPrefs.GetString("EQUIPMENT1ARMOUR") != null)
        {
            GameInformation.Equipment1Armour = (BaseItem)PPSerialization.Load("EQUIPMENT1ARMOUR");
        }
        if (PlayerPrefs.GetString("EQUIPMENT1ACCESSORY") != null)
        {
            GameInformation.Equipment1Accessory = (BaseItem)PPSerialization.Load("EQUIPMENT1ACCESSORY");
        }

        if (PlayerPrefs.GetString("EQUIPMENT2WEAPON") != null)
        {
            GameInformation.Equipment2Weapon = (BaseItem)PPSerialization.Load("EQUIPMENT2WEAPON");
        }
        if (PlayerPrefs.GetString("EQUIPMENT2ARMOUR") != null)
        {
            GameInformation.Equipment2Armour = (BaseItem)PPSerialization.Load("EQUIPMENT2ARMOUR");
        }
        if (PlayerPrefs.GetString("EQUIPMENT2ACCESSORY") != null)
        {
            GameInformation.Equipment2Accessory = (BaseItem)PPSerialization.Load("EQUIPMENT2ACCESSORY");
        }

        if (PlayerPrefs.GetString("EQUIPMENT3WEAPON") != null)
        {
            GameInformation.Equipment3Weapon = (BaseItem)PPSerialization.Load("EQUIPMENT3WEAPON");
        }
        if (PlayerPrefs.GetString("EQUIPMENT3ARMOUR") != null)
        {
            GameInformation.Equipment3Armour = (BaseItem)PPSerialization.Load("EQUIPMENT3ARMOUR");
        }
        if (PlayerPrefs.GetString("EQUIPMENT3ACCESSORY") != null)
        {
            GameInformation.Equipment3Accessory = (BaseItem)PPSerialization.Load("EQUIPMENT3ACCESSORY");
        }

        if (PlayerPrefs.GetString("EQUIPMENT4WEAPON") != null)
        {
            GameInformation.Equipment4Weapon = (BaseItem)PPSerialization.Load("EQUIPMENT4WEAPON");
        }
        if (PlayerPrefs.GetString("EQUIPMENT4ARMOUR") != null)
        {
            GameInformation.Equipment4Armour = (BaseItem)PPSerialization.Load("EQUIPMENT4ARMOUR");
        }
        if (PlayerPrefs.GetString("EQUIPMENT4ACCESSORY") != null)
        {
            GameInformation.Equipment4Accessory = (BaseItem)PPSerialization.Load("EQUIPMENT4ACCESSORY");
        }

    }
}
