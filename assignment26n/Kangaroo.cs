using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment26n
{
public class Kangaroo : Creature , IRunnable , IJumpable
{

    public void Run()
    {
        Debug.Log("Kangaroo runs.");
    }
    public void Jump()
    {
        Debug.Log("Kangaroo jumps.");
    }

    public override void Speak()
    {
        Debug.Log("Kangaroo says: Hop!");
    }




}
}