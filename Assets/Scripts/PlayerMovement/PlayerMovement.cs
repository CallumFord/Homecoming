using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey("a"))
        {
            transform.Translate((Vector2.left)*moveSpeed*Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate((Vector2.right) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("w"))
        {
            transform.Translate((Vector2.up) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate((Vector2.down) * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKeyDown("z"))
        {
            Application.LoadLevel("Battle");
        }
        if (Input.GetKeyDown("x"))
        {
            //Cancel Key
        }
	}
}
