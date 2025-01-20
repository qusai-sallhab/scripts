using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace assignment35
{
public class TestAbstractClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DerivedClassExample test=new DerivedClassExample();
        test.PerformAction();
        test.PrintInfo();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}