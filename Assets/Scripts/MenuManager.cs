using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public GameObject AttempScoreObject;

    private void Awake()
    {
        Instance = this;
    }

    public void SetAttemp(int attempCount)
    {
        AttempScoreObject.GetComponentInChildren<Text>().text = "Attemps: "+attempCount.ToString();
    }
}

