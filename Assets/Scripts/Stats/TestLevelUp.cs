using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevelUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
        NewGame.NewGameInformation();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("EXP + 10"))
        {
            IncreaseExperience.AddExperience(10);
        }
        if (GUILayout.Button("EXP + 100"))
        {
            IncreaseExperience.AddExperience(100);
        }
        if (GUILayout.Button("EXP + 1000"))
        {
            IncreaseExperience.AddExperience(1000);
        }
    }
}
