using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UIElements.Experimental;


namespace assignment18
{
public class Character 
{
    public string name;
    private int health;
    protected Position position;


    public int Health
    {
        get{return health;}
        set{if(value>=0&&value<=100)health=value;}
    }

    public Character(string name ,int health,Position position)
    {
        this.name=name;
        Health=health;
        this.position=position;
    }

    public Character() : this("no name",100,new Position(0,0,0))
    {

    }

    public virtual void DisplayInfo()
    {
        Debug.Log(name);
        Debug.Log(Health);
        position.PrintPosition();
    }

    public void Attack(int damageAmmount,Character target)
    {
        target.Health-=damageAmmount;
    }
    public void Attack(int damageAmmount,Character target ,string attackType)
    {
        Attack(damageAmmount,target);
        Debug.Log(attackType);
    }
        


}
}