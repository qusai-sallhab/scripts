using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment26n
{
public class Duck : Creature , IRunnable, ISwimmable
{
    public void Run()
    {
        Debug.Log("Duck runs.");
    }
    
    public void Swim()
    {
        Debug.Log("Duck swims.");
    }

    public override void Speak()
    {
        Debug.Log("Duck says: Quack!");
    }


}
}