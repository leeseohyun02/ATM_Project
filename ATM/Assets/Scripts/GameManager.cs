using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI banlanceTxt;
    public TextMeshProUGUI playerNameTxt;

    public List<PlayerInfo> playerInfo = new List<PlayerInfo>();
    public PlayerInfo player;

    private void Awake()
    {
        if (I == null)
        {
            I = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        playerNameTxt.text = player.playerName;
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
        cashTxt.text = player.playerCash.ToString("#,##0");
        banlanceTxt.text = player.playerBanlance.ToString("#,##0");
    }
}
