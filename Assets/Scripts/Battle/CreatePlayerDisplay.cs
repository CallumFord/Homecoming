using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerDisplay : MonoBehaviour {

    //Creates Player in-battle displays and portraits.
	public static void CreatePlayer ()
    {
        float xpos = -4f; //The xposition for generating player Battle Displays and Portraits
        foreach(BasePlayer Player in GameInformation.PartyList)
        {
            GameObject PlayerDisplay = (GameObject)Instantiate(Resources.Load("BattleDisplay_Blank"), new Vector3(xpos, -5.6f, 0), new Quaternion());
            GameObject PlayerPortrait = (GameObject)Instantiate(Resources.Load("Player_Portrait"), new Vector3(xpos, -3.3f, 0), new Quaternion());
            xpos += 2.5f;
        }
    }
}
	
