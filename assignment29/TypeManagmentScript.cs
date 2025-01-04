using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment29
{
public class TypeManagmentScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animal cat=new Cat();
        cat.MakeSound();
        cat.Move();

        Cat cat1=cat as Cat;
        cat1.MakeSound();
        cat1.Move();

        List<ICanFight> canFights=new List<ICanFight>();

        canFights.Add(cat1);
        canFights.Add(new Warior());

        foreach(ICanFight canFight in canFights)
        {
            canFight.Attack();
            if(canFight is Cat)Debug.Log("The object is a Cat.");
            else Debug.Log("The object is a Warrior.");
        }
                
    }


}

public class Animal
{
    public virtual void MakeSound()
    {
        Debug.Log("Animal sound");
    }
    public void Move()
    {
        Debug.Log("Animal moves");
    }
}

public class Cat:Animal ,ICanFight
{
    public override void MakeSound()
    {
        Debug.Log("Meow!");
    }
    public new void Move()
    {
        Debug.Log("Cat runs quickly.");
    }

    public void Attack()
    {
        Debug.Log("Cat attacks with claws!");
    }

}

public interface ICanFight
{
    public void Attack();
}


public class Warior :ICanFight
{
    public void Attack()
    {
        Debug.Log("Warrior attacks with a sword!");
    }
}


}