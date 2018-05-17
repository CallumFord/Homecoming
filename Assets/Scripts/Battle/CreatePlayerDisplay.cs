using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerDisplay : MonoBehaviour {

    
	public static void CreatePlayer () //Creates Player in-battle displays and portraits.
    {
        float xpos = -5.1f; //The xposition for generating player Battle Displays and Portraits
        int Playercount = 1;
        foreach(BasePlayer Player in GameInformation.PartyList)
        {

            GameObject BattleDisplay = new GameObject("BattleDisplay" + Playercount); //Creates a game object to represent the stats of the current player in-battle
            SpriteRenderer BattleDisplaySpriteRenderer = BattleDisplay.AddComponent<SpriteRenderer>(); //Assigns a sprite renderer to the player object, allowing a sprite to be assigned to it
            BattleDisplaySpriteRenderer.sprite = Resources.Load<Sprite>("BattleDisplay"); //Loads the "BattleDisplay" sprite from the resources folder
            BattleDisplaySpriteRenderer.sortingLayerName = "Foreground"; //Moves the player object into the Foreground
            BattleDisplay.transform.position = new Vector2(xpos + 0.6f, -5.5f); //Positions the player object


            GameObject PlayerPortrait = new GameObject("PlayerPortrait" + Playercount); //Creates a game object to represent the portrait of the current player in-battle
            SpriteRenderer PlayerPortraitSpriteRenderer = PlayerPortrait.AddComponent<SpriteRenderer>(); //Assigns a sprite renderer to the player object, allowing a sprite to be assigned to it
            PlayerPortraitSpriteRenderer.sprite = Resources.Load<Sprite>(Player.PlayerClass.PortraitSprite); //Loads the player's portrait corresponding to their class
            PlayerPortraitSpriteRenderer.sortingLayerName = "Foreground"; //Moves the player's portrait into the foreground
            PlayerPortraitSpriteRenderer.transform.localScale = new Vector2(3, 3); //Scales the player portrait
            PlayerPortrait.transform.position = new Vector2(xpos + 0.6f, -2.85f); //Positions the player portrait

            xpos += 3f; //Changes the relative position of subsequent player displays
            Playercount += 1; //Changes the name of the game objects representing the different players
        }
    }

    public static void CreateEnemy() //Creates Enemy in-battle sprites
    {
        float xpos = -4f;
        int enemyCount = 1;
        foreach (BaseEnemy Enemy in GameInformation.EnemiesList)
        {
            GameObject EnemyDisplay = new GameObject("Enemy" + enemyCount); //Creates an object that represents the enemy in-battle
            SpriteRenderer EnemyDisplaySpriteRenderer = EnemyDisplay.AddComponent<SpriteRenderer>(); //Assigns a sprite renderer to the player object, allowing a sprite to be assigned to it
            EnemyDisplaySpriteRenderer.sprite = Resources.Load<Sprite>(Enemy.Sprite); //Loads the enemy's image corresponding to their type
            EnemyDisplaySpriteRenderer.sortingLayerName = "Foreground"; //Moves the enemy into the foreground
            EnemyDisplay.transform.position = new Vector2(xpos, 4.6f); //Positions the enemy
            xpos += 3.0f; //Changes the relative position between enemies
            enemyCount += 1; //Changes the name of the game objects representing different enemies
        }

    }
    public static void CreateBattlePanel() //Creates battle command window
    {       
        var Canvas = GameObject.Find("BattleCanvas"); //Creates a variable to represent the in-battle canvas

        GameObject BattlePanel = new GameObject("BattlePanel"); //Creates the battle panel that appears during the player's turn
        RectTransform rectBattlePanel = BattlePanel.AddComponent<RectTransform>(); //Adds a rectTransform, allowing for scaling and positioning
        rectBattlePanel.localScale = new Vector2(5.5f, 1.5f); //Scales the Battle Panel
        rectBattlePanel.position = new Vector2(0f, -10f); //Positions the battle panel

        Image panelImage = BattlePanel.AddComponent<Image>(); //Adds an image component to the battle panel
        panelImage.sprite = Resources.Load<Sprite>("TextField"); //Loads the TextField graphic from the resources folder
        BattlePanel.transform.SetParent(Canvas.transform, false); //Makes the battle panel a child of the in-battle canvas

        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf"); //Loads the ArialFont from the built in resources

        GameObject AttackCommand = new GameObject("AttackCommand"); //Creates a new object to represent the Attack Command
        RectTransform AttackRect = AttackCommand.AddComponent<RectTransform>(); //Adds a rectTransform, allowing for scaling and positioning
        Text AttackText = AttackCommand.AddComponent<Text>(); //Adds text to the game object
        AttackText.text = "ATTACK"; //Assigns the text
        AttackText.font = ArialFont; //Assigns the font
        AttackCommand.transform.position = new Vector2(-100, -30); //Positions the game object

        GameObject SpecialCommand = new GameObject("SpecialCommand");
        RectTransform SpecialRect = SpecialCommand.AddComponent<RectTransform>();
        Text SpecialText = SpecialCommand.AddComponent<Text>();
        SpecialText.text = "SPECIAL";
        SpecialText.font = ArialFont;
        SpecialText.material = ArialFont.material;
        SpecialText.transform.position = new Vector2(100, -30);

        GameObject ItemCommand = new GameObject("ItemCommand");
        RectTransform ItemRect = ItemCommand.AddComponent<RectTransform>();
        Text ItemText = ItemCommand.AddComponent<Text>();
        ItemText.text = "ITEM";
        ItemText.font = ArialFont;
        ItemText.material = ArialFont.material;
        ItemCommand.transform.position = new Vector2(-100, -60);

        GameObject RunCommand = new GameObject("RunCommand");
        RectTransform RunRect = RunCommand.AddComponent<RectTransform>();
        Text RunText = RunCommand.AddComponent<Text>();
        RunText.text = "RUN";
        RunText.font = ArialFont;
        RunText.material = ArialFont.material;
        RunCommand.transform.position = new Vector2(100, -60);

        //Makes the text objects children of the in-battle canvas
        AttackCommand.transform.SetParent(Canvas.transform, false);
        SpecialCommand.transform.SetParent(Canvas.transform, false);
        ItemCommand.transform.SetParent(Canvas.transform, false);
        RunCommand.transform.SetParent(Canvas.transform, false);


    }
}
	
