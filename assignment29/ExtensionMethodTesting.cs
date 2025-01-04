using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment29
{
public class ExtensionMethodTesting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Debug.Log(Utilities.Add(3,5,7,8,3,2,6,4));
       Debug.Log("qusai".RepeatString(10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

}
