using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment29
{
public class TestingCustomObject : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        CustomObject o1=new CustomObject(10,"dog");
        CustomObject o2=new CustomObject(10,"dog");

        if(o1==o2)Debug.Log("yes the objects are the same");
        if(o1!=o2)Debug.Log("no the objects are different");
        print(o1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}