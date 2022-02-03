using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text OP1;
    public Text OP2;
    public InputField ResultField;
    public Text MessageText;
    public int MaxOp = 10;
    public int MinOp = 1;
    private int _op1Val,_op2Val;
    public FinalScore FinalScore;


    void Start()
    {
        ResetGame();
    }

    public void VerifyResult()
    {
        Debug.Log("VerifyResult");

        int value = int.Parse(ResultField.text);
        
        if (value == _op1Val + _op2Val)
        {
            MessageText.text = "OK";
            FinalScore.Setup(100);
        } else
        {
            MessageText.text = "NOK";
            ResultField.text = "";
        }

        ResultField.ActivateInputField();
    }

    private void ResetGame()
    {
        _op1Val = Random.Range(MinOp, MaxOp);
        _op2Val = Random.Range(MinOp, MaxOp);
        OP1.text = _op1Val.ToString();
        OP2.text = _op2Val.ToString();
        MessageText.text = "";
        ResultField.ActivateInputField();
    }
}
