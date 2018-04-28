using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

	public static void SaveAllInformation() //This function is called when the player saves their game file, overwrites stored game information with new values
    {
        PlayerPrefs.SetInt("PLAYER2", GameInformation.Player2);
        PlayerPrefs.SetInt("PLAYER3", GameInformation.Player3);
        PlayerPrefs.SetInt("PLAYER4", GameInformation.Player4);

        PlayerPrefs.SetInt("PROGRESS", GameInformation.StoryProgress);
        PlayerPrefs.SetInt("MONEY", GameInformation.Money);

        PlayerPrefs.SetInt("PLAYER1LEVEL", GameInformation.Player1Level);
        PlayerPrefs.SetInt("PLAYER1EXP", GameInformation.Player1Experience);
        PlayerPrefs.SetString("PLAYER1CLASS", GameInformation.Player1Class);
        PlayerPrefs.SetInt("ATTACK1", GameInformation.Attack1);
        PlayerPrefs.SetInt("DEFENCE1", GameInformation.Defence1);
        PlayerPrefs.SetInt("HEALTH1", GameInformation.Health1);
        PlayerPrefs.SetInt("MAGIC1", GameInformation.Magic1);

        PlayerPrefs.SetInt("PLAYER2LEVEL", GameInformation.Player2Level);
        PlayerPrefs.SetInt("PLAYER2EXP", GameInformation.Player2Experience);
        PlayerPrefs.SetString("PLAYER2CLASS", GameInformation.Player2Class);
        PlayerPrefs.SetInt("ATTACK2", GameInformation.Attack2);
        PlayerPrefs.SetInt("DEFENCE2", GameInformation.Defence2);
        PlayerPrefs.SetInt("HEALTH2", GameInformation.Health2);
        PlayerPrefs.SetInt("MAGIC2", GameInformation.Magic2);

        PlayerPrefs.SetInt("PLAYER3LEVEL", GameInformation.Player3Level);
        PlayerPrefs.SetInt("PLAYER3EXP", GameInformation.Player3Experience);
        PlayerPrefs.SetString("PLAYER3CLASS", GameInformation.Player3Class);
        PlayerPrefs.SetInt("ATTACK3", GameInformation.Attack3);
        PlayerPrefs.SetInt("DEFENCE3", GameInformation.Defence3);
        PlayerPrefs.SetInt("HEALTH3", GameInformation.Health3);
        PlayerPrefs.SetInt("MAGIC3", GameInformation.Magic3);

        PlayerPrefs.SetInt("PLAYER4LEVEL", GameInformation.Player4Level);
        PlayerPrefs.SetInt("PLAYER4EXP", GameInformation.Player4Experience);
        PlayerPrefs.SetString("PLAYER4CLASS", GameInformation.Player4Class);
        PlayerPrefs.SetInt("ATTACK4", GameInformation.Attack4);
        PlayerPrefs.SetInt("DEFENCE4", GameInformation.Defence4);
        PlayerPrefs.SetInt("HEALTH4", GameInformation.Health4);
        PlayerPrefs.SetInt("MAGIC4", GameInformation.Magic4);
        if (GameInformation.Equipment1Weapon != null)
        {
            PPSerialization.Save("EQUIPMENT1WEAPON", GameInformation.Equipment1Weapon);
        }
        if (GameInformation.Equipment1Armour != null)
        {
            PPSerialization.Save("EQUIPMENT1ARMOUR", GameInformation.Equipment1Armour);
        }
        if (GameInformation.Equipment1Accessory != null)
        {
            PPSerialization.Save("EQUIPMENT1ACCESSORY", GameInformation.Equipment1Accessory);
        }

        if (GameInformation.Equipment2Weapon != null)
        {
            PPSerialization.Save("EQUIPMENT2WEAPON", GameInformation.Equipment2Weapon);
        }
        if (GameInformation.Equipment2Armour != null)
        {
            PPSerialization.Save("EQUIPMENT2ARMOUR", GameInformation.Equipment2Armour);
        }
        if (GameInformation.Equipment2Accessory != null)
        {
            PPSerialization.Save("EQUIPMENT2ACCESSORY", GameInformation.Equipment2Accessory);
        }

        if (GameInformation.Equipment3Weapon != null)
        {
            PPSerialization.Save("EQUIPMENT3WEAPON", GameInformation.Equipment3Weapon);
        }
        if (GameInformation.Equipment3Armour != null)
        {
            PPSerialization.Save("EQUIPMENT3ARMOUR", GameInformation.Equipment3Armour);
        }
        if (GameInformation.Equipment3Accessory != null)
        {
            PPSerialization.Save("EQUIPMENT3ACCESSORY", GameInformation.Equipment3Accessory);
        }

        if (GameInformation.Equipment4Weapon != null)
        {
            PPSerialization.Save("EQUIPMENT4WEAPON", GameInformation.Equipment4Weapon);
        }
        if (GameInformation.Equipment4Armour != null)
        {
            PPSerialization.Save("EQUIPMENT4ARMOUR", GameInformation.Equipment4Armour);
        }
        if (GameInformation.Equipment4Accessory != null)
        {
            PPSerialization.Save("EQUIPMENT4ACCESSORY", GameInformation.Equipment4Accessory);
        }


    }
}
