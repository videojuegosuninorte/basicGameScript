using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text op1;
    public Text op2;
    public InputField resultField;
    public Text messageText;
    public int maxOp = 10;
    public int minOp = 1;
    private int op1Val,op2Val;


    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VerifyResult()
    {
        Debug.Log("VerifyResult");

        int value = int.Parse(resultField.text);
        
        if (value == op1Val + op2Val)
        {
            messageText.text = "OK";
        } else
        {
            messageText.text = "NOK";
            resultField.text = "";
        }

        resultField.ActivateInputField();
    }

    private void ResetGame()
    {
        op1Val = Random.Range(minOp, maxOp);
        op2Val = Random.Range(minOp, maxOp);
        op1.text = op1Val.ToString();
        op2.text = op2Val.ToString();
        messageText.text = "";
        resultField.ActivateInputField();
    }
}
