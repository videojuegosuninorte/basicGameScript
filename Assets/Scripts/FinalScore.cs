using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// this script manages the scoreBoard
public class FinalScore : MonoBehaviour
{
    public Text scoreText;

    // called to show the board
    public void Setup(int score)
    {
        gameObject.SetActive(true);  // the default state is false
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneName: "GameScene");  // reload the scene
    }
}
