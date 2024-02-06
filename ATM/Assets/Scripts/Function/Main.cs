using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main: MonoBehaviour
{
    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI banlanceTxt;
    public TextMeshProUGUI playerNameTxt;


    // Start is called before the first frame update
    void Start()
    {
        playerNameTxt.text = GameManager.I.player.playerName;
        updateText(); 
    }

    public void onClickDeposit()
    {
        SceneManager.LoadScene("DepositScene");
    }

    public void onClickWithdrow()
    {
        SceneManager.LoadScene("WithdrawScene");
    }

    public void updateText()
    {
        cashTxt.text = GameManager.I.player.playerCash.ToString("#,##0");
        banlanceTxt.text = GameManager.I.player.playerBanlance.ToString("#,##0");
    }
}

