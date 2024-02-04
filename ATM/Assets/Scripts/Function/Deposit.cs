using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Deposit : MonoBehaviour
{
    [SerializeField] private InputField inputField;
    [SerializeField] private int playerInput;

    private const int tenThousand= 10000;
    private const int thirtyThousand = 30000;
    private const int fiftyThousand = 50000;

    public GameData gameData;

    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI balanceTxt;

    public GameObject popUp;


    void Start()
    {
        inputField.contentType = InputField.ContentType.IntegerNumber;
        inputField.onValueChanged.AddListener(TextChanged);


    }

    void Update()
    {
        UpdateText();
    }

    private void DepositAmount(int amount)
    {
        if (gameData.cash < amount)
        {
            popUp.SetActive(true);
            return;
        }
      
        gameData.cash -= amount;
        gameData.balance += amount;


        UpdateText();
    }

    public void TenThousand()
    {
        DepositAmount(tenThousand);
    }

    public void ThirtyThousand()
    {
        DepositAmount(thirtyThousand);
    }

    public void FiftyThousand()
    {
        DepositAmount(fiftyThousand);
    }

    public void DirectinputBtn()
    {
        DepositAmount(playerInput);
    }

    private void TextChanged(string text)
    {
        if (!string.IsNullOrEmpty(text) && !int.TryParse(text,out _))
        {
            inputField.text = "";
            
        }
        playerInput = int.Parse(inputField.text);
        
    }

    private void UpdateText()
    {
        cashTxt.text = gameData.cash.ToString("#,##0");
        balanceTxt.text = gameData.balance.ToString("#,##0");
    }

    public void OnCheckBtn()
    {
        popUp.SetActive(false);
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("MainScene");
    }
}

