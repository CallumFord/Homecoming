using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LoadInformation.LoadAllInformation();
        Debug.Log(GameInformation.Player1Level);
        Debug.Log(GameInformation.Attack1);
        Debug.Log(GameInformation.Defence1);
        Debug.Log(GameInformation.Health1);
        Debug.Log(GameInformation.Magic1);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
