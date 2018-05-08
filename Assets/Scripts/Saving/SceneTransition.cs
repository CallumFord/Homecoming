using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition : MonoBehaviour
{
    public void ChangeScene(string scene, Vector2 playerPosition)
    {
        Application.LoadLevel(scene);
        GameObject Player = (GameObject)Instantiate(Resources.Load("Player"), playerPosition, new Quaternion());
    }

}
