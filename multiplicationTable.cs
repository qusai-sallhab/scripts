using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int i=1;i<11;i++)
        {
            Debug.Log(5+" x "+i+" = "+multiply(i,5));

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int multiply (int x, int y)
    {
        return (x*y);
    }
}
