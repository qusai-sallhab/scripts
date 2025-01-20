using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment35
{
public class BuiltInDelegatesExample : MonoBehaviour
{
    Action<string> logMessage;
    Func<int,int> square;
    Predicate<int>isEven;
    // Start is called before the first frame update
    void Start()
    {
        logMessage=(string str)=> Debug.Log(str);
        logMessage("Hello from Action delegate!");

        square=(int num)=>num*num;
        Debug.Log($"Square: {square(5)}");

        isEven=(int num)=>num%2==0;
        Debug.Log($"Is 4 even? {isEven(4)}");
    }

    
}
}