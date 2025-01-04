using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallByValueAndRefrence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a=4;
        int b=6;
        int c;

        Debug.Log("before adding attempt "+a);
        Add_10_points(a);
        Debug.Log("after adding attempt "+a);

        Debug.Log("before adding attempt "+b);
        Add_10_pointsCallByRef(ref b);
        Debug.Log("after adding attempt "+b);

        AssignValue(out c);
        Debug.Log("c assigned with value "+c);

    }

    void Add_10_points(int num)
    {
        num+=10;
    }

    void Add_10_pointsCallByRef(ref int num)
    {
        num+=10;
    }

    void AssignValue(out int num)
    {
        num=17;
    }

    
}
