using System.Collections;
using System.Collections.Generic;
using assignment14;
using UnityEngine;

namespace assignment14
{
public class Enemy : Character
{
    public Enemy(string name , int health) : base(name,health)
    {

    }

    public void Attack(int damageAmmount,Character attackedChar)
    {
        attackedChar.Health-=damageAmmount;

    }

}
}