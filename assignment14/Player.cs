using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment14
{
public class Player : Character
{

    public Player(string name,int health): base(name,health)
    {

    }

    public void Heal(int ammount)
    {
        if(Health+ammount<=100)
        Health+=ammount;
    }


}
}
