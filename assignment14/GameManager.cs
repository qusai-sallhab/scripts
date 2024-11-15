using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment14
{
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player=new Player("subhi",65);
        Enemy enemy=new Enemy("Madeeha",90);
        Debug.Log(player.Name);
        Debug.Log(player.Health);
        Debug.Log(enemy.Name);
        Debug.Log(enemy.Health);


        player.Heal(1034);
        Debug.Log(player.Health);
        player.Heal(10);
        Debug.Log(player.Health);   

        enemy.Attack(25,player);
        Debug.Log(player.Health);
        enemy.Attack(25,player);
        Debug.Log(player.Health);

    }

    // Update is called once per frame  
    void Update()
    {
        
    }
}
}
