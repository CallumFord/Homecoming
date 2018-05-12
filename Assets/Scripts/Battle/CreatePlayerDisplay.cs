using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePlayerDisplay : MonoBehaviour {

    
	public static void CreatePlayer () //Creates Player in-battle displays and portraits.
    {
        float xpos = -5.1f; //The xposition for generating player Battle Displays and Portraits
        foreach(BasePlayer Player in GameInformation.PartyList)
        {
            GameObject BattleDisplay = new GameObject("BattleDisplay");
            BattleDisplay.AddComponent<CanvasRenderer>();
            SpriteRenderer BattleDisplaySpriteRenderer = BattleDisplay.AddComponent<SpriteRenderer>();
            BattleDisplaySpriteRenderer.sprite = Resources.Load<Sprite>("BattleDisplay");
            BattleDisplaySpriteRenderer.sortingLayerName = "Foreground";
            BattleDisplay.transform.position = new Vector2(xpos + 0.6f, -5.5f);

            GameObject PlayerPortrait = new GameObject("PlayerPortrait");
            SpriteRenderer PlayerPortraitSpriteRenderer = PlayerPortrait.AddComponent<SpriteRenderer>();
            PlayerPortraitSpriteRenderer.sprite = Resources.Load<Sprite>("Player_Portrait");
            PlayerPortraitSpriteRenderer.sortingLayerName = "Foreground";

            PlayerPortraitSpriteRenderer.transform.localScale = new Vector2(3, 3);
            PlayerPortrait.transform.position = new Vector2(xpos + 0.6f, -2.85f);

            xpos += 3f;
        }
    }

    public static void CreateEnemy() //Creates Enemy in-battle sprites
    {
        float xpos = -4f;
        foreach (BaseEnemy Enemy in GameInformation.EnemiesList)
        {
            GameObject EnemyDisplay = new GameObject("Enemy");
            SpriteRenderer EnemyDisplaySpriteRenderer = EnemyDisplay.AddComponent<SpriteRenderer>();
            EnemyDisplaySpriteRenderer.sprite = Resources.Load<Sprite>(Enemy.Sprite);
            EnemyDisplaySpriteRenderer.sortingLayerName = "Foreground";
            EnemyDisplay.transform.position = new Vector2(xpos, 4.6f);
            xpos += 3.0f;
        }

    }
    public static void CreateBattlePanel() //Creates battle command window
    {       
        GameObject Canvas = new GameObject("Canvas");
        Canvas newCanvas = Canvas.AddComponent<Canvas>();
        newCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        Canvas.AddComponent<CanvasScaler>();
        Canvas.AddComponent<GraphicRaycaster>();

        GameObject BattlePanel = new GameObject("BattlePanel");
        RectTransform rectBattlePanel = BattlePanel.AddComponent<RectTransform>();
        rectBattlePanel.localScale = new Vector2(5.5f, 1.5f);
        rectBattlePanel.position = new Vector2(0f, -10f);

        BattlePanel.AddComponent<CanvasRenderer>();
        Image panelImage = BattlePanel.AddComponent<Image>();
        panelImage.sprite = Resources.Load<Sprite>("TextField");
        BattlePanel.transform.SetParent(Canvas.transform, false);

    }
}
	
