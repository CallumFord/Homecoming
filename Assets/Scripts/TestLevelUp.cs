using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevelUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NewGame.NewGameInformation();
        Debug.Log(GameInformation.Attack1);
        Debug.Log("Lv: " + GameInformation.Player1Level + "   " + GameInformation.Player1Experience + "/" + GameInformation.Player1Required+ " xp - ATK:" + GameInformation.Attack1 + "  DEF:" + GameInformation.Defence1 + "  HP:" + GameInformation.Health1 + "  MP:" + GameInformation.Magic1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("EXP + 10"))
        {
            IncreaseExperience.AddExperience(10);
            Debug.Log("Lv: " + GameInformation.Player1Level + "   " + GameInformation.Player1Experience + "/" + GameInformation.Player1Required + " xp - ATK:" + GameInformation.Attack1 + "  DEF:" + GameInformation.Defence1 + "  HP:" + GameInformation.Health1 + "  MP:" + GameInformation.Magic1);
        }
        if (GUILayout.Button("EXP + 100"))
        {
            IncreaseExperience.AddExperience(100);
            Debug.Log("Lv: " + GameInformation.Player1Level + "   " + GameInformation.Player1Experience + "/" + GameInformation.Player1Required + " xp - ATK:" + GameInformation.Attack1 + "  DEF:" + GameInformation.Defence1 + "  HP:" + GameInformation.Health1 + "  MP:" + GameInformation.Magic1);
        }
        if (GUILayout.Button("EXP + 1000"))
        {
            IncreaseExperience.AddExperience(1000);
            Debug.Log("Lv: " + GameInformation.Player1Level + "   " + GameInformation.Player1Experience + "/" + GameInformation.Player1Required + " xp - ATK:" + GameInformation.Attack1 + "  DEF:" + GameInformation.Defence1 + "  HP:" + GameInformation.Health1 + "  MP:" + GameInformation.Magic1);
        }
    }
}
