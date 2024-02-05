using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField _idInput;
    public InputField _passwordInput;

    private string _playerId;
    private string _playerPw;

    public GameObject loginUi;
    public GameObject mainUi;
    public GameObject signUpUi;

    public void inputLogin()
    {
        _playerId = _idInput.text;
        _playerPw = _passwordInput.text;

        string _storeId = PlayerPrefs.GetString("PlayerID");
        string _storePw = PlayerPrefs.GetString("PlayerPW");

        if (_playerId == _storeId && _playerPw == _storePw)
        {
            Debug.Log("로그인 성공");
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            _idInput.text = "";
            _passwordInput.text = "";
            Debug.Log("로그인 실패");
        }
        
    }

    public void signUpBtn()
    {
        signUpUi.SetActive(true);
    }
}
