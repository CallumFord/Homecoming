using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLevelUp : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        NewGame.NewGameInformation();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if(GUILayout.Button("EXP + 10"))
        {
            LevelUp.AddExperience(10);
        }
        if (GUILayout.Button("EXP + 100"))
        {
            LevelUp.AddExperience(100);
        }
        if (GUILayout.Button("EXP + 1000"))
        {
            LevelUp.AddExperience(1000);
        }
        if (GUILayout.Button("EXP + 10000"))
        {
            LevelUp.AddExperience(10000);
        }
    }
}
