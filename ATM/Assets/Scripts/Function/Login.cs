using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    public InputField _id;
    public InputField _password;

    private string _playerId = "aa";
    private string _playerPw = "aa";

    public GameObject loginUi;
    public GameObject mainUi;
    public GameObject signUpUi;

    public void inputLogin()
    {
        if(_id.text == _playerId && _password.text == _playerPw)
        {
            _playerId = _id.text;
            _password.text = _playerPw;

            SceneManager.LoadScene("MainScene");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
        
    }

    public void signUpBtn()
    {
        signUpUi.SetActive(true);
    }
}
