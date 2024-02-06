using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public List<PlayerInfo> playerInfo = new List<PlayerInfo>();
    public PlayerInfo player;

    private void Awake()
    {
        if (I == null)
        {
            I = this;
            DontDestroyOnLoad(gameObject);           
        }
    }

}
