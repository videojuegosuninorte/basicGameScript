using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text OP1;
    public Text OP2;
    public InputField ResultField;
    public Text MessageText;
    public int MaxOp = 10;
    public int MinOp = 1;
    private int _op1Val,_op2Val;
    public FinalScore FinalScore;
    private int _attempCount = 0;


    // Start is called just before any of the Update methods is called the first time
    void Start()
    {
        ResetGame();
    }

    // called from the onSubmitt of the resultField 
    public void VerifyResult()
    {
        Debug.Log("VerifyResult");

        int value = int.Parse(ResultField.text);
        
        if (value == _op1Val + _op2Val)
        {
            MessageText.text = "OK";
            // show the score board
            FinalScore.Setup(100 -_attempCount*10);
        } else
        {
            _attempCount++;
            MenuManager.Instance.SetAttemp(_attempCount);
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
