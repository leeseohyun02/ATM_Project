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
    public GameObject signUpUi;

    public void inputLogin()
    {
        _playerId = _idInput.text;
        _playerPw = _passwordInput.text;

        string _storeId = PlayerPrefs.GetString("PlayerID");
        string _storePw = PlayerPrefs.GetString("PlayerPW");

        foreach(var player in GameManager.I.playerInfo)
        {
            if (_playerId == player.playerId && _playerPw == player.playerPw)
            {
                Debug.Log("�α��� ����");
                SceneManager.LoadScene("MainScene");
            }
            else
            {
                _idInput.text = "";
                _passwordInput.text = "";
                Debug.Log("�α��� ����");
            }
        }   
        
    }

    public void signUpBtn()
    {
        signUpUi.SetActive(true);
    }
}
