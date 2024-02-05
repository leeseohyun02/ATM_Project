using System.Collections;
using System.Collections.Generic;
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
            Debug.Log("비어있으면 안됩니다.");
            return;
        }
        if(PlayerPrefs.HasKey(_playerId)) 
        {
            Debug.Log("사용자 이미 존재");
        }

        PlayerPrefs.SetString(_playerId, _playerPassword);
        PlayerPrefs.Save();

        Debug.Log("사용자 등록 완료 : " +  _playerName);

        signUpUi.SetActive(false);
    }

    
    public void onClickCancel()
    {
        signUpUi.SetActive(false);
    }
}
