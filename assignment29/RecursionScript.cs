using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment29
{
public class RecursionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
        Debug.Log(FibonacciRecursive(10));
        Debug.Log(FibonacciRecursive(30));

        Debug.Log(FibonacciIterative(10));
        Debug.Log(FibonacciIterative(30));


    }

    int  FibonacciRecursive(int n)
    {

         if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

    }

     int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int previous = 0, current = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = current;
            current += previous;
            previous = temp;
        }

        return current;
    }

}
}