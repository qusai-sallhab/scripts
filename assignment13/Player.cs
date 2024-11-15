using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    public string playerName;
    public int health;

    public static int playerCount;

    public void InitializePlayer(string name, int initialHealth)
    {
        playerName=name;
        health=initialHealth;
        playerCount++;
    } 

    public void heal(int amount)
    {
        //################# NOTE
        //this condition is not required but i huess i have to put it as i saw in the lectures 
        if(health+amount<=100)
        health+=amount;
        Debug.Log(health);
    }
    public void heal(bool fullRestore)
    {
        if(fullRestore)
        health=100;
        Debug.Log(health);
    }

    public static void ShowPlayerCount()
    {
        Debug.Log(playerCount);
    }


}
