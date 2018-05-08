using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInformation {

	public static void SaveAllInformation() //This function is called when the player saves their game file, overwrites stored game information with new values
    {

        PPSerialization.Save("PLAYERLIST", GameInformation.PlayerList);
        PPSerialization.Save("PARTYLIST", GameInformation.PartyList);

        PlayerPrefs.SetInt("PROGRESS", GameInformation.StoryProgress);
        PlayerPrefs.SetInt("MONEY", GameInformation.Money);
    }
}
