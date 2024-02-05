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

        if(CheckLogin(_playerId,_playerPw))
        {
            Debug.Log("로그인 성공");
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
        
    }
    private bool CheckLogin(string playerId, string playerPw)
    {
        string checkId = PlayerPrefs.GetString(playerId, "");
        return checkId == playerPw;
    }

    public void signUpBtn()
    {
        signUpUi.SetActive(true);
    }
}
