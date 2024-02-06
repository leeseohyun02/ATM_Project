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

    public GameObject signUpUi;

    public TextMeshProUGUI errorText;

    public void inputSignUp()
    {
        _playerId = _idInput.text;
        _playerName = _nameInput.text;
        _playerPassword = _passwordInput.text;
        _plaeryPC = _passwordConfirmInput.text;

        inputCheck();    

    }
    private void inputCheck()
    {
        if (string.IsNullOrEmpty(_playerId) || string.IsNullOrEmpty(_playerName)
            || string.IsNullOrEmpty(_playerPassword) || string.IsNullOrEmpty(_plaeryPC))
        {
            errorText.text = "모두 입력해 주세요.";
            return;
        }

        if(PlayerPrefs.HasKey(_playerId)) 
        {
            errorText.text = "이미 존재하는 사용자 입니다.";
            return;
        }

        if(!(3<=_playerId.Length && _playerId.Length<=10))
        {
            errorText.text = "ID는 3~10글자 사이의 영어, 숫자만 입력 가능합니다.";
            return;
        }

        if(!(2<=_playerName.Length && _playerName.Length <= 5))
        {
            errorText.text = "Name은 2~5글자만 가능합니다.";
            return;
        }

        if (!(5 <= _playerPassword.Length && _playerPassword.Length <= 15))
        {
            errorText.text = "PS는 5~15글자 사이의 영어, 숫자만 입력 가능합니다.";
            return;
        }
        if (_playerPassword != _plaeryPC)
        {
            errorText.text = "비밀번호가 일치하지 않습니다.";
            return;
        }

        PlayerPrefs.SetString("PlayerID", _playerId);
        PlayerPrefs.SetString("PlayerPW", _playerPassword);
        PlayerPrefs.SetString("PlayerName", _playerName);

        PlayerPrefs.Save();

        Debug.Log("사용자 등록 완료 : " +  _playerName);

        signUpUi.SetActive(false);

    }

    
    public void onClickCancel()
    {
        signUpUi.SetActive(false);
    }
}
