using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment26n
{
public class CreatureManager : MonoBehaviour
{
    List<Creature> creatures;
    List<IRunnable> runnables;
    List<IJumpable> Jumpables;
    List<ISwimmable> swimmables;

    Kangaroo kangaroo;
    Duck duck;
    // Start is called before the first frame update
    void Start()
    {
        creatures=new List<Creature>();
        runnables=new List<IRunnable>();
        Jumpables=new List<IJumpable>();
        swimmables=new List<ISwimmable>();
        kangaroo=new Kangaroo();
        duck=new Duck();


        creatures.Add(kangaroo);
        creatures.Add(duck);

        runnables.Add(kangaroo);
        Jumpables.Add(kangaroo);

        runnables.Add(duck);
        swimmables.Add(duck);

        kangaroo.Speak();
        duck.Speak();

        foreach(IRunnable runnable in runnables) runnable.Run();

        foreach(ISwimmable swimmable in swimmables) swimmable.Swim();
        
        foreach(IJumpable jumpable in Jumpables) jumpable.Jump();




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}