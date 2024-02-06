using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Withdraw : MonoBehaviour
{

    [SerializeField] private InputField _inputField;
    [SerializeField] private int _playerInput;

    private const int _tenThousand = 10000;
    private const int _thirtyThousand = 30000;
    private const int _fiftyThousand = 50000;

    public TextMeshProUGUI cashTxt;
    public TextMeshProUGUI banlanceTxt;

    public GameObject popUp;


    void Start()
    {
        _inputField.onValueChanged.AddListener(textChanged);

    }

    void Update()
    {
        updateText();
    }

    private void depositAmount(int amount)
    {
        if (gameData.banlance < amount)
        {
            popUp.SetActive(true);
            return;
        }

        gameData.cash += amount;
        gameData.banlance -= amount;

    }

    public void tenThousand()
    {
        depositAmount(_tenThousand);
    }

    public void thirtyThousand()
    {
        depositAmount(_thirtyThousand);
    }

    public void fiftyThousand()
    {
        depositAmount(_fiftyThousand);
    }

    public void directinputBtn()
    {
        depositAmount(_playerInput);
    }

    private void textChanged(string text)
    {
        if (!string.IsNullOrEmpty(text) && !int.TryParse(text, out int result))
        {
            _inputField.text = "";

        }
        _playerInput = int.Parse(_inputField.text);

    }

    private void updateText()
    {
        cashTxt.text = gameData.cash.ToString("#,##0");
        banlanceTxt.text = gameData.banlance.ToString("#,##0");
    }

    public void onCheckBtn()
    {
        popUp.SetActive(false);
    }

    public void onClickBack()
    {
        SceneManager.LoadScene("MainScene");
    }
}
