using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInformation {

    public static void LoadAllInformation() //This function is called when the player loads their game file, overwrites game information with stored values
    {

        GameInformation.PlayerList = (List<BasePlayer>)PPSerialization.Load("PLAYERLIST");
        GameInformation.PartyList = (List<BasePlayer>)PPSerialization.Load("PARTYLIST");
        GameInformation.StoryProgress = PlayerPrefs.GetInt("PROGRESS");
        GameInformation.Money = PlayerPrefs.GetInt("MONEY");

    }
}
