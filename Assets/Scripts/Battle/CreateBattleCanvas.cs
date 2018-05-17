using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateBattleCanvas
{
	public static void BattleCanvas(string canvasName)
    {
        GameObject Canvas = new GameObject(canvasName);
        Canvas newCanvas = Canvas.AddComponent<Canvas>();
        newCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        Canvas.AddComponent<CanvasScaler>();
        Canvas.AddComponent<GraphicRaycaster>();
    }
}
