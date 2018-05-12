using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayer {

    public static void CreatePlayerObject(Vector2 position)
    {
        GameObject Player = new GameObject("Player"); //Creates a game object called "Player" to represent the player
        Player.AddComponent<PlayerMovement>(); //Assigns the PlayerMovement.cs script to the player

        SpriteRenderer playerSpriteRenderer = Player.AddComponent <SpriteRenderer>(); //Creates a sprite renderer for the player
        playerSpriteRenderer.sprite = Resources.Load<Sprite>("Player"); //Loads the player sprite from the resources folder
        playerSpriteRenderer.sortingLayerName = "Player"; //Moves the player sprite to the "Player" layer, which is in front of the background and behind the foreground

        BoxCollider2D playerCollider = Player.AddComponent<BoxCollider2D>(); //Creates a box collider around the player

        Player.transform.position = position; //Moves the player object to the specified position

    }
}
