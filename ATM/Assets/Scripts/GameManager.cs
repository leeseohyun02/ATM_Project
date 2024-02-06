using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public GameData gameData;

    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI banlanceTxt;
    public TextMeshProUGUI playerNameTxt;

    private void Awake()
    {
        if (I == null)
        {
            I = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerNameTxt.text = PlayerPrefs.GetString("PlayerName");
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
        cashTxt.text = gameData.cash.ToString("#,##0");
        banlanceTxt.text = gameData.banlance.ToString("#,##0");
    }
}
