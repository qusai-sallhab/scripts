using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment14
{
public class Character 
{
    private String name;
    private int health;

    public string Name
    {
        set{name=value;}
        get{return this.name;}
    }
    public int Health
    {
        set{if(value<=100)this.health=value;}
        get{return this.health;}
    }

    public Character(string name,int health)
    {
        Name=name;
        Health=health;
    }


}
}