using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameLogic : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log("Is it doing?");
        SceneManager.LoadScene(sceneName: "GameScene");
    }
}
