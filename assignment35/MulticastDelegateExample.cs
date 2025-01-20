using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment35
{
public class MulticastDelegateExample : MonoBehaviour
{
    delegate void MathOperation(int number);
    // Start is called before the first frame update
    void Start()
    {
        MathOperation operation;
        operation = DoubleNumber; // ما رضي هون += 
        operation += SquareNumber;
        operation += CubeNumber;
       
        operation(5);
        
    }
    void DoubleNumber (int number)=> Debug.Log(2*number);
    void SquareNumber(int number)=> Debug.Log(number*number);
    void CubeNumber(int number)=> Debug.Log(number*number*number);
}
}