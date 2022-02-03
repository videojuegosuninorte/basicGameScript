using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text scoreText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(sceneName: "GameScene");
    }
}
