using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    [SerializeField]private InputField _id;
    [SerializeField]private InputField _password;
    [SerializeField]private string _playerId;
    [SerializeField] private string _playerPw;

    public GameObject loginUi;
    public GameObject mainUi;


    public void inputLogin()
    {
        if(!string.IsNullOrEmpty(_playerId) && !string.IsNullOrEmpty(_playerPw))
        {
            _playerId = _id.text;
            _password.text = _playerPw;
        }

        loginUi.SetActive(false);
        mainUi.SetActive(true);
    }
}
