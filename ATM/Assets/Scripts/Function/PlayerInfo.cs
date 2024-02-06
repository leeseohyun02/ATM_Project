using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerInfo 
{
    public string playerId {get; set;}
    public string playerName{ get; set; }
    public string playerPw { get; set; }
    public int playerCash { get; set; }
    public int playerBanlance { get; set; }

    public PlayerInfo(string playerId, string playerName, string playerPw, int playerCash, int playerBanlance)
    {
        this.playerId = playerId;
        this.playerName = playerName;
        this.playerPw = playerPw;
        this.playerCash = playerCash;
        this.playerBanlance = playerBanlance;
    }
}


