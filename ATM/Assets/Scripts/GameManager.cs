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
    public TextMeshProUGUI balanceTxt;
   

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
        UpdateText();
    }


    public void OnClickDeposit()
    {
        SceneManager.LoadScene("DepositScene");
    }

    public void OnClickWithdrow()
    {
        SceneManager.LoadScene("WithdrawScene");
    }

    public void UpdateText()
    {
        cashTxt.text = gameData.cash.ToString("#,##0");
        balanceTxt.text = gameData.balance.ToString("#,##0");
    }
}
