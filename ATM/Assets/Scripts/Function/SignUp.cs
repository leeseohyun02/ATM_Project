using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SignUp : MonoBehaviour
{
    [SerializeField] private InputField _idInput;
    [SerializeField] private InputField _nameInput;
    [SerializeField] private InputField _passwordInput;
    [SerializeField] private InputField _passwordConfirmInput;

    private string _playerId;
    private string _playerName;
    private string _playerPassword;
    private string _plaeryPC;
    private int _playerCash;
    private int _plaeyrBanlance;

    public GameObject signUpUi;

    public TextMeshProUGUI errorText;

    private GameManager gameManager;
    public void inputSignUp()
    {
        _playerId = _idInput.text;
        _playerName = _nameInput.text;
        _playerPassword = _passwordInput.text;
        _plaeryPC = _passwordConfirmInput.text;

        onClickInputCheck();    

    }
    private void onClickInputCheck()
    {

        if (string.IsNullOrEmpty(_playerId) || string.IsNullOrEmpty(_playerName)
        || string.IsNullOrEmpty(_playerPassword) || string.IsNullOrEmpty(_plaeryPC))
        {
            errorText.text = "��� �Է��� �ּ���.";
            return;
        }

        if (_playerId == gameManager.player.playerId)
        {
            errorText.text = "�̹� �����ϴ� ����� �Դϴ�.";
            return;
        }

        if (!(3 <= _playerId.Length && _playerId.Length <= 10))
        {
            errorText.text = "ID�� 3~10���� ������ ����, ���ڸ� �Է� �����մϴ�.";
            return;
        }

        if (!(2 <= _playerName.Length && _playerName.Length <= 5))
        {
            errorText.text = "Name�� 2~5���ڸ� �����մϴ�.";
            return;
        }

        if (!(5 <= _playerPassword.Length && _playerPassword.Length <= 15))
        {
            errorText.text = "PS�� 5~15���� ������ ����, ���ڸ� �Է� �����մϴ�.";
            return;
        }
        if (_playerPassword != _plaeryPC)
        {
            errorText.text = "��й�ȣ�� ��ġ���� �ʽ��ϴ�.";
            return;
        }

        PlayerInfo newPlayer = new PlayerInfo(_playerId, _playerName, _playerPassword, 100000, 20000);
        GameManager.I.playerInfo.Add(newPlayer);
            

        Debug.Log("����� ��� �Ϸ� : " + _playerName);

        signUpUi.SetActive(false);


    }

    
    public void onClickCancel()
    {
        signUpUi.SetActive(false);
    }
}
