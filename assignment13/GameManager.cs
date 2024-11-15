using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        Player player2=new Player();

        player1.InitializePlayer("qusai",75);
        player2.InitializePlayer("rami",95);


        player1.heal(15);
        player2.heal(true);



        Player.ShowPlayerCount();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
